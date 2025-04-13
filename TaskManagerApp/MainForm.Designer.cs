
namespace TaskManagerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPersons;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TextBox textBoxPersonName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonUpdatePerson;
        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDue;
        private System.Windows.Forms.ComboBox comboBoxResponsible;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonUpdateTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.ComboBox comboBoxFilterStatus;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSortByName;
        private System.Windows.Forms.Button buttonSortByDueDate;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchTask;
        private System.Windows.Forms.Label labelTaskProgress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewPersons = new System.Windows.Forms.DataGridView();
            dataGridViewTasks = new System.Windows.Forms.DataGridView();
            textBoxPersonName = new System.Windows.Forms.TextBox();
            dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            textBoxEmail = new System.Windows.Forms.TextBox();
            buttonAddPerson = new System.Windows.Forms.Button();
            buttonUpdatePerson = new System.Windows.Forms.Button();
            buttonDeletePerson = new System.Windows.Forms.Button();
            textBoxTaskName = new System.Windows.Forms.TextBox();
            textBoxDescription = new System.Windows.Forms.TextBox();
            dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
            comboBoxResponsible = new System.Windows.Forms.ComboBox();
            comboBoxStatus = new System.Windows.Forms.ComboBox();
            buttonAddTask = new System.Windows.Forms.Button();
            buttonUpdateTask = new System.Windows.Forms.Button();
            buttonDeleteTask = new System.Windows.Forms.Button();
            comboBoxFilterStatus = new System.Windows.Forms.ComboBox();
            buttonFilter = new System.Windows.Forms.Button();
            buttonSortByName = new System.Windows.Forms.Button();
            buttonSortByDueDate = new System.Windows.Forms.Button();
            textBoxSearch = new System.Windows.Forms.TextBox();
            buttonSearchTask = new System.Windows.Forms.Button();
            labelTaskProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPersons
            // 
            dataGridViewPersons.ColumnHeadersHeight = 34;
            dataGridViewPersons.Location = new System.Drawing.Point(20, 20);
            dataGridViewPersons.Name = "dataGridViewPersons";
            dataGridViewPersons.RowHeadersWidth = 62;
            dataGridViewPersons.Size = new System.Drawing.Size(360, 150);
            dataGridViewPersons.TabIndex = 0;
            // 
            // dataGridViewTasks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTasks.ColumnHeadersHeight = 34;
            dataGridViewTasks.Location = new System.Drawing.Point(400, 20);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 62;
            dataGridViewTasks.Size = new System.Drawing.Size(600, 250);
            dataGridViewTasks.TabIndex = 1;
            // 
            // textBoxPersonName
            // 
            textBoxPersonName.Location = new System.Drawing.Point(20, 180);
            textBoxPersonName.Name = "textBoxPersonName";
            textBoxPersonName.Size = new System.Drawing.Size(100, 31);
            textBoxPersonName.TabIndex = 2;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new System.Drawing.Point(20, 210);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new System.Drawing.Size(200, 31);
            dateTimePickerBirthday.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(20, 240);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(100, 31);
            textBoxEmail.TabIndex = 4;
            // 
            // buttonAddPerson
            // 
            buttonAddPerson.Location = new System.Drawing.Point(20, 270);
            buttonAddPerson.Name = "buttonAddPerson";
            buttonAddPerson.Size = new System.Drawing.Size(75, 23);
            buttonAddPerson.TabIndex = 5;
            buttonAddPerson.Text = "Add Person";
            buttonAddPerson.Click += buttonAddPerson_Click;
            // 
            // buttonUpdatePerson
            // 
            buttonUpdatePerson.Location = new System.Drawing.Point(120, 270);
            buttonUpdatePerson.Name = "buttonUpdatePerson";
            buttonUpdatePerson.Size = new System.Drawing.Size(75, 23);
            buttonUpdatePerson.TabIndex = 6;
            buttonUpdatePerson.Text = "Update Person";
            buttonUpdatePerson.Click += buttonUpdatePerson_Click;
            // 
            // buttonDeletePerson
            // 
            buttonDeletePerson.Location = new System.Drawing.Point(220, 270);
            buttonDeletePerson.Name = "buttonDeletePerson";
            buttonDeletePerson.Size = new System.Drawing.Size(75, 23);
            buttonDeletePerson.TabIndex = 7;
            buttonDeletePerson.Text = "Delete Person";
            buttonDeletePerson.Click += buttonDeletePerson_Click;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new System.Drawing.Point(400, 280);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new System.Drawing.Size(100, 31);
            textBoxTaskName.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(400, 310);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(100, 31);
            textBoxDescription.TabIndex = 9;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new System.Drawing.Point(400, 340);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new System.Drawing.Size(200, 31);
            dateTimePickerStart.TabIndex = 10;
            // 
            // dateTimePickerDue
            // 
            dateTimePickerDue.Location = new System.Drawing.Point(400, 370);
            dateTimePickerDue.Name = "dateTimePickerDue";
            dateTimePickerDue.Size = new System.Drawing.Size(200, 31);
            dateTimePickerDue.TabIndex = 11;
            // 
            // comboBoxResponsible
            // 
            comboBoxResponsible.Location = new System.Drawing.Point(400, 400);
            comboBoxResponsible.Name = "comboBoxResponsible";
            comboBoxResponsible.Size = new System.Drawing.Size(121, 33);
            comboBoxResponsible.TabIndex = 12;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Location = new System.Drawing.Point(400, 430);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new System.Drawing.Size(121, 33);
            comboBoxStatus.TabIndex = 13;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new System.Drawing.Point(400, 460);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new System.Drawing.Size(75, 23);
            buttonAddTask.TabIndex = 14;
            buttonAddTask.Text = "Add Task";
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonUpdateTask
            // 
            buttonUpdateTask.Location = new System.Drawing.Point(500, 460);
            buttonUpdateTask.Name = "buttonUpdateTask";
            buttonUpdateTask.Size = new System.Drawing.Size(75, 23);
            buttonUpdateTask.TabIndex = 15;
            buttonUpdateTask.Text = "Update Task";
            buttonUpdateTask.Click += buttonUpdateTask_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new System.Drawing.Point(600, 460);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new System.Drawing.Size(75, 23);
            buttonDeleteTask.TabIndex = 16;
            buttonDeleteTask.Text = "Delete Task";
            buttonDeleteTask.Click += buttonDeleteTask_Click;
            // 
            // comboBoxFilterStatus
            // 
            comboBoxFilterStatus.Location = new System.Drawing.Point(20, 320);
            comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            comboBoxFilterStatus.Size = new System.Drawing.Size(121, 33);
            comboBoxFilterStatus.TabIndex = 17;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new System.Drawing.Point(180, 320);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new System.Drawing.Size(75, 23);
            buttonFilter.TabIndex = 18;
            buttonFilter.Text = "Filter";
            buttonFilter.Click += buttonFilter_Click;
            // 
            // buttonSortByName
            // 
            buttonSortByName.Location = new System.Drawing.Point(20, 360);
            buttonSortByName.Name = "buttonSortByName";
            buttonSortByName.Size = new System.Drawing.Size(75, 23);
            buttonSortByName.TabIndex = 19;
            buttonSortByName.Text = "Sort by Name";
            buttonSortByName.Click += buttonSortByName_Click;
            // 
            // buttonSortByDueDate
            // 
            buttonSortByDueDate.Location = new System.Drawing.Point(180, 360);
            buttonSortByDueDate.Name = "buttonSortByDueDate";
            buttonSortByDueDate.Size = new System.Drawing.Size(75, 23);
            buttonSortByDueDate.TabIndex = 20;
            buttonSortByDueDate.Text = "Sort by Due Date";
            buttonSortByDueDate.Click += buttonSortByDueDate_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new System.Drawing.Point(20, 400);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(100, 31);
            textBoxSearch.TabIndex = 21;
            // 
            // buttonSearchTask
            // 
            buttonSearchTask.Location = new System.Drawing.Point(180, 400);
            buttonSearchTask.Name = "buttonSearchTask";
            buttonSearchTask.Size = new System.Drawing.Size(75, 23);
            buttonSearchTask.TabIndex = 22;
            buttonSearchTask.Text = "Search Task";
            buttonSearchTask.Click += buttonSearchTask_Click;
            // 
            // labelTaskProgress
            // 
            labelTaskProgress.Location = new System.Drawing.Point(20, 440);
            labelTaskProgress.Name = "labelTaskProgress";
            labelTaskProgress.Size = new System.Drawing.Size(300, 20);
            labelTaskProgress.TabIndex = 23;
            labelTaskProgress.Text = "Task Manager - Progress Overview";
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(1282, 642);
            Controls.Add(dataGridViewPersons);
            Controls.Add(dataGridViewTasks);
            Controls.Add(textBoxPersonName);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonAddPerson);
            Controls.Add(buttonUpdatePerson);
            Controls.Add(buttonDeletePerson);
            Controls.Add(textBoxTaskName);
            Controls.Add(textBoxDescription);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerDue);
            Controls.Add(comboBoxResponsible);
            Controls.Add(comboBoxStatus);
            Controls.Add(buttonAddTask);
            Controls.Add(buttonUpdateTask);
            Controls.Add(buttonDeleteTask);
            Controls.Add(comboBoxFilterStatus);
            Controls.Add(buttonFilter);
            Controls.Add(buttonSortByName);
            Controls.Add(buttonSortByDueDate);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearchTask);
            Controls.Add(labelTaskProgress);
            Name = "MainForm";
            Text = "Task Manager (Beautiful UI)";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
