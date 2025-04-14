
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPersons
            // 
            dataGridViewPersons.ColumnHeadersHeight = 34;
            dataGridViewPersons.Location = new System.Drawing.Point(36, 86);
            dataGridViewPersons.Name = "dataGridViewPersons";
            dataGridViewPersons.RowHeadersWidth = 62;
            dataGridViewPersons.Size = new System.Drawing.Size(428, 178);
            dataGridViewPersons.TabIndex = 0;
            // 
            // dataGridViewTasks
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTasks.ColumnHeadersHeight = 34;
            dataGridViewTasks.Location = new System.Drawing.Point(470, 86);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 62;
            dataGridViewTasks.Size = new System.Drawing.Size(800, 236);
            dataGridViewTasks.TabIndex = 1;
            // 
            // textBoxPersonName
            // 
            textBoxPersonName.Location = new System.Drawing.Point(156, 284);
            textBoxPersonName.Name = "textBoxPersonName";
            textBoxPersonName.Size = new System.Drawing.Size(201, 31);
            textBoxPersonName.TabIndex = 2;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new System.Drawing.Point(155, 316);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new System.Drawing.Size(201, 31);
            dateTimePickerBirthday.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(154, 350);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(202, 31);
            textBoxEmail.TabIndex = 4;
            // 
            // buttonAddPerson
            // 
            buttonAddPerson.Location = new System.Drawing.Point(154, 387);
            buttonAddPerson.Name = "buttonAddPerson";
            buttonAddPerson.Size = new System.Drawing.Size(76, 32);
            buttonAddPerson.TabIndex = 5;
            buttonAddPerson.Text = "Add Person";
            buttonAddPerson.Click += buttonAddPerson_Click;
            // 
            // buttonUpdatePerson
            // 
            buttonUpdatePerson.Location = new System.Drawing.Point(236, 387);
            buttonUpdatePerson.Name = "buttonUpdatePerson";
            buttonUpdatePerson.Size = new System.Drawing.Size(76, 32);
            buttonUpdatePerson.TabIndex = 6;
            buttonUpdatePerson.Text = "Update Person";
            buttonUpdatePerson.Click += buttonUpdatePerson_Click;
            // 
            // buttonDeletePerson
            // 
            buttonDeletePerson.Location = new System.Drawing.Point(318, 387);
            buttonDeletePerson.Name = "buttonDeletePerson";
            buttonDeletePerson.Size = new System.Drawing.Size(76, 32);
            buttonDeletePerson.TabIndex = 7;
            buttonDeletePerson.Text = "Delete Person";
            buttonDeletePerson.Click += buttonDeletePerson_Click;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new System.Drawing.Point(580, 335);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new System.Drawing.Size(103, 31);
            textBoxTaskName.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(580, 365);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(103, 31);
            textBoxDescription.TabIndex = 9;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new System.Drawing.Point(580, 395);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new System.Drawing.Size(203, 31);
            dateTimePickerStart.TabIndex = 10;
            // 
            // dateTimePickerDue
            // 
            dateTimePickerDue.Location = new System.Drawing.Point(580, 425);
            dateTimePickerDue.Name = "dateTimePickerDue";
            dateTimePickerDue.Size = new System.Drawing.Size(203, 31);
            dateTimePickerDue.TabIndex = 11;
            // 
            // comboBoxResponsible
            // 
            comboBoxResponsible.Location = new System.Drawing.Point(580, 455);
            comboBoxResponsible.Name = "comboBoxResponsible";
            comboBoxResponsible.Size = new System.Drawing.Size(124, 33);
            comboBoxResponsible.TabIndex = 12;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Location = new System.Drawing.Point(580, 485);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new System.Drawing.Size(124, 33);
            comboBoxStatus.TabIndex = 13;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new System.Drawing.Point(580, 522);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new System.Drawing.Size(78, 37);
            buttonAddTask.TabIndex = 14;
            buttonAddTask.Text = "Add Task";
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonUpdateTask
            // 
            buttonUpdateTask.Location = new System.Drawing.Point(664, 522);
            buttonUpdateTask.Name = "buttonUpdateTask";
            buttonUpdateTask.Size = new System.Drawing.Size(78, 37);
            buttonUpdateTask.TabIndex = 15;
            buttonUpdateTask.Text = "Update Task";
            buttonUpdateTask.Click += buttonUpdateTask_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new System.Drawing.Point(748, 524);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new System.Drawing.Size(78, 37);
            buttonDeleteTask.TabIndex = 16;
            buttonDeleteTask.Text = "Delete Task";
            buttonDeleteTask.Click += buttonDeleteTask_Click;
            // 
            // comboBoxFilterStatus
            // 
            comboBoxFilterStatus.Location = new System.Drawing.Point(134, 444);
            comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            comboBoxFilterStatus.Size = new System.Drawing.Size(154, 33);
            comboBoxFilterStatus.TabIndex = 17;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new System.Drawing.Point(294, 444);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new System.Drawing.Size(76, 32);
            buttonFilter.TabIndex = 18;
            buttonFilter.Text = "Filter";
            buttonFilter.Click += buttonFilter_Click;
            // 
            // buttonSortByName
            // 
            buttonSortByName.Location = new System.Drawing.Point(134, 484);
            buttonSortByName.Name = "buttonSortByName";
            buttonSortByName.Size = new System.Drawing.Size(76, 32);
            buttonSortByName.TabIndex = 19;
            buttonSortByName.Text = "Sort by Name";
            buttonSortByName.Click += buttonSortByName_Click;
            // 
            // buttonSortByDueDate
            // 
            buttonSortByDueDate.Location = new System.Drawing.Point(294, 484);
            buttonSortByDueDate.Name = "buttonSortByDueDate";
            buttonSortByDueDate.Size = new System.Drawing.Size(76, 32);
            buttonSortByDueDate.TabIndex = 20;
            buttonSortByDueDate.Text = "Sort by Due Date";
            buttonSortByDueDate.Click += buttonSortByDueDate_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new System.Drawing.Point(134, 522);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(154, 31);
            textBoxSearch.TabIndex = 21;
            // 
            // buttonSearchTask
            // 
            buttonSearchTask.Location = new System.Drawing.Point(294, 524);
            buttonSearchTask.Name = "buttonSearchTask";
            buttonSearchTask.Size = new System.Drawing.Size(76, 32);
            buttonSearchTask.TabIndex = 22;
            buttonSearchTask.Text = "Search Task";
            buttonSearchTask.Click += buttonSearchTask_Click;
            // 
            // labelTaskProgress
            // 
            labelTaskProgress.Location = new System.Drawing.Point(134, 564);
            labelTaskProgress.Name = "labelTaskProgress";
            labelTaskProgress.Size = new System.Drawing.Size(301, 29);
            labelTaskProgress.TabIndex = 23;
            labelTaskProgress.Text = "Task Manager - Progress Overview";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(294, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(448, 45);
            label1.TabIndex = 24;
            label1.Text = "Task Management Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(36, 284);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 25);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(36, 316);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 25);
            label3.TabIndex = 25;
            label3.Text = "Date_Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(470, 338);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 25);
            label4.TabIndex = 25;
            label4.Text = "Task";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(40, 353);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 25);
            label5.TabIndex = 25;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(470, 371);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(109, 25);
            label6.TabIndex = 25;
            label6.Text = "Description";
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(1282, 642);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
