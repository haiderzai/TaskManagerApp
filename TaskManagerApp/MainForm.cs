using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TaskManagerApp
{
    public partial class MainForm : Form
    {
        private List<Person> persons = new List<Person>();
        private List<TaskItem> tasks = new List<TaskItem>();
        private readonly string personFile = "persons.csv";
        private readonly string taskFile = "tasks.csv";

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            PopulateComboBoxes();
            RefreshGrids();

            dataGridViewPersons.CellClick += DataGridViewPersons_CellClick;
            dataGridViewPersons.CellDoubleClick += DataGridViewPersons_CellClick;

            dataGridViewTasks.CellClick += DataGridViewTasks_CellClick;
            dataGridViewTasks.CellDoubleClick += DataGridViewTasks_CellClick;
        }

        private void LoadData()
        {
            persons.Clear();
            tasks.Clear();

            if (File.Exists(personFile))
            {
                foreach (var line in File.ReadAllLines(personFile))
                {
                    var parts = line.Split(',');
                    persons.Add(new Person { Name = parts[0], Birthday = DateTime.Parse(parts[1]), Email = parts[2] });
                }
            }

            if (File.Exists(taskFile))
            {
                foreach (var line in File.ReadAllLines(taskFile))
                {
                    var parts = line.Split(',');
                    var person = persons.FirstOrDefault(p => p.Email == parts[4]);
                    tasks.Add(new TaskItem
                    {
                        Name = parts[0],
                        Description = parts[1],
                        StartDate = DateTime.Parse(parts[2]),
                        DueDate = DateTime.Parse(parts[3]),
                        ResponsiblePerson = person,
                        Status = (TaskStatus)Enum.Parse(typeof(TaskStatus), parts[5])
                    });
                }
            }
        }

        private void SaveData()
        {
            File.WriteAllLines(personFile, persons.Select(p => $"{p.Name},{p.Birthday.ToShortDateString()},{p.Email}"));
            File.WriteAllLines(taskFile, tasks.Select(t => $"{t.Name},{t.Description},{t.StartDate.ToShortDateString()},{t.DueDate.ToShortDateString()},{t.ResponsiblePerson?.Email},{t.Status}"));
        }

        private void PopulateComboBoxes()
        {
            comboBoxResponsible.DataSource = null;
            comboBoxResponsible.DataSource = persons;
            comboBoxResponsible.DisplayMember = "Name";

            comboBoxStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
            comboBoxFilterStatus.Items.Clear();
            comboBoxFilterStatus.Items.Add("All");
            comboBoxFilterStatus.Items.AddRange(Enum.GetNames(typeof(TaskStatus)));
            comboBoxFilterStatus.SelectedIndex = 0;
        }

        private void RefreshGrids()
        {
            dataGridViewPersons.DataSource = null;
            dataGridViewPersons.DataSource = persons.Select(p => new { p.Name, Birthday = p.Birthday.ToShortDateString(), p.Email }).ToList();

            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = tasks.Select(t => new
            {
                t.Name,
                t.Description,
                StartDate = t.StartDate.ToShortDateString(),
                DueDate = t.DueDate.ToShortDateString(),
                Responsible = t.ResponsiblePerson?.Name,
                t.Status
            }).ToList();
        }

        private void ClearPersonInputs()
        {
            textBoxPersonName.Clear();
            textBoxEmail.Clear();
            dateTimePickerBirthday.Value = DateTime.Today;
        }

        private void ClearTaskInputs()
        {
            textBoxTaskName.Clear();
            textBoxDescription.Clear();
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerDue.Value = DateTime.Today;
            comboBoxResponsible.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
        }

        private bool ValidatePersonInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxPersonName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter both Name and Email for the person.");
                return false;
            }
            return true;
        }

        private bool ValidateTaskInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxTaskName.Text) ||
                comboBoxResponsible.SelectedIndex == -1 ||
                comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in Task Name, assign a Responsible Person, and select a Status.");
                return false;
            }
            return true;
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            if (!ValidatePersonInputs()) return;

            persons.Add(new Person
            {
                Name = textBoxPersonName.Text,
                Birthday = dateTimePickerBirthday.Value,
                Email = textBoxEmail.Text
            });

            SaveData();
            PopulateComboBoxes();
            RefreshGrids();
            ClearPersonInputs();
        }

        private void buttonUpdatePerson_Click(object sender, EventArgs e)
        {
            if (!ValidatePersonInputs()) return;

            if (dataGridViewPersons.CurrentRow != null)
            {
                string email = dataGridViewPersons.CurrentRow.Cells[2].Value.ToString();
                var person = persons.FirstOrDefault(p => p.Email == email);
                if (person != null)
                {
                    person.Name = textBoxPersonName.Text;
                    person.Birthday = dateTimePickerBirthday.Value;
                    person.Email = textBoxEmail.Text;
                    SaveData();
                    PopulateComboBoxes();
                    RefreshGrids();
                    ClearPersonInputs();
                }
            }
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersons.CurrentRow != null)
            {
                string email = dataGridViewPersons.CurrentRow.Cells[2].Value.ToString();
                persons.RemoveAll(p => p.Email == email);
                SaveData();
                PopulateComboBoxes();
                RefreshGrids();
                ClearPersonInputs();
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (!ValidateTaskInputs()) return;

            tasks.Add(new TaskItem
            {
                Name = textBoxTaskName.Text,
                Description = textBoxDescription.Text,
                StartDate = dateTimePickerStart.Value,
                DueDate = dateTimePickerDue.Value,
                ResponsiblePerson = (Person)comboBoxResponsible.SelectedItem,
                Status = (TaskStatus)comboBoxStatus.SelectedItem
            });

            SaveData();
            RefreshGrids();
            ClearTaskInputs();
        }

        private void buttonUpdateTask_Click(object sender, EventArgs e)
        {
            if (!ValidateTaskInputs()) return;

            if (dataGridViewTasks.CurrentRow != null)
            {
                string name = dataGridViewTasks.CurrentRow.Cells[0].Value.ToString();
                var task = tasks.FirstOrDefault(t => t.Name == name);
                if (task != null)
                {
                    task.Description = textBoxDescription.Text;
                    task.StartDate = dateTimePickerStart.Value;
                    task.DueDate = dateTimePickerDue.Value;
                    task.ResponsiblePerson = (Person)comboBoxResponsible.SelectedItem;
                    task.Status = (TaskStatus)comboBoxStatus.SelectedItem;
                    SaveData();
                    RefreshGrids();
                    ClearTaskInputs();
                }
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow != null)
            {
                string name = dataGridViewTasks.CurrentRow.Cells[0].Value.ToString();
                tasks.RemoveAll(t => t.Name == name);
                SaveData();
                RefreshGrids();
                ClearTaskInputs();
            }
        }

        private void buttonSearchTask_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.ToLower();
            var results = tasks.Where(t =>
                t.Name.ToLower().Contains(searchTerm) ||
                t.Description.ToLower().Contains(searchTerm) ||
                t.ResponsiblePerson?.Name.ToLower().Contains(searchTerm) == true
            );
            dataGridViewTasks.DataSource = results.Select(t => new
            {
                t.Name,
                t.Description,
                StartDate = t.StartDate.ToShortDateString(),
                DueDate = t.DueDate.ToShortDateString(),
                Responsible = t.ResponsiblePerson?.Name,
                t.Status
            }).ToList();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string selected = comboBoxFilterStatus.SelectedItem.ToString();
            var filtered = selected == "All" ? tasks : tasks.Where(t => t.Status.ToString() == selected);
            dataGridViewTasks.DataSource = filtered.Select(t => new
            {
                t.Name,
                t.Description,
                StartDate = t.StartDate.ToShortDateString(),
                DueDate = t.DueDate.ToShortDateString(),
                Responsible = t.ResponsiblePerson?.Name,
                t.Status
            }).ToList();
        }

        private void buttonSortByName_Click(object sender, EventArgs e)
        {
            tasks = tasks.OrderBy(t => t.Name).ToList();
            RefreshGrids();
        }

        private void buttonSortByDueDate_Click(object sender, EventArgs e)
        {
            tasks = tasks.OrderBy(t => t.DueDate).ToList();
            RefreshGrids();
        }

        private void DataGridViewPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewPersons.Rows[e.RowIndex];
                textBoxPersonName.Text = row.Cells[0].Value.ToString();
                dateTimePickerBirthday.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                textBoxEmail.Text = row.Cells[2].Value.ToString();
                row.Selected = true;
            }
        }

        private void DataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewTasks.Rows[e.RowIndex];
                textBoxTaskName.Text = row.Cells[0].Value.ToString();
                textBoxDescription.Text = row.Cells[1].Value.ToString();
                dateTimePickerStart.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                dateTimePickerDue.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                comboBoxResponsible.SelectedItem = persons.FirstOrDefault(p => p.Name == row.Cells[4].Value.ToString());
                comboBoxStatus.SelectedItem = Enum.Parse(typeof(TaskStatus), row.Cells[5].Value.ToString());
                row.Selected = true;
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
    }

    public class TaskItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public Person ResponsiblePerson { get; set; }
        public TaskStatus Status { get; set; }
    }

    public enum TaskStatus
    {
        Todo,
        Ongoing,
        Done
    }
}
