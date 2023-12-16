namespace WinFormsApp
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchComboBox = new ComboBox();
            backToMenu_button = new Button();
            dataGridViewStudents = new DataGridView();
            search_Button = new Button();
            searchTextBox = new TextBox();
            addStudent_Button = new Button();
            deleteStudent_Button = new Button();
            dataGridViewStudentClasses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentClasses).BeginInit();
            SuspendLayout();
            // 
            // searchComboBox
            // 
            searchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "ID", "Name", "Surname", "Patronymic", "Class_ID", "Dormitory_ID", "Room_ID" });
            searchComboBox.Location = new Point(228, 12);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(90, 23);
            searchComboBox.TabIndex = 4;
            searchComboBox.Tag = "";

            // 
            // backToMenu_button
            // 
            backToMenu_button.Location = new Point(12, 415);
            backToMenu_button.Name = "backToMenu_button";
            backToMenu_button.Size = new Size(75, 23);
            backToMenu_button.TabIndex = 0;
            backToMenu_button.Text = "Back";
            backToMenu_button.UseVisualStyleBackColor = true;
            backToMenu_button.Click += backToMenu_button_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(228, 48);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(424, 390);
            dataGridViewStudents.StandardTab = true;
            dataGridViewStudents.TabIndex = 1;
            dataGridViewStudents.CellClick += dataGridViewStudents_CellClick;
            // 
            // search_Button
            // 
            search_Button.Location = new Point(504, 11);
            search_Button.Name = "search_Button";
            search_Button.Size = new Size(75, 23);
            search_Button.TabIndex = 2;
            search_Button.Text = "Search";
            search_Button.UseVisualStyleBackColor = true;
            search_Button.Click += search_Button_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(324, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(174, 23);
            searchTextBox.TabIndex = 3;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // addStudent_Button
            // 
            addStudent_Button.Location = new Point(51, 183);
            addStudent_Button.Name = "addStudent_Button";
            addStudent_Button.Size = new Size(129, 23);
            addStudent_Button.TabIndex = 5;
            addStudent_Button.Text = "Add student";
            addStudent_Button.UseVisualStyleBackColor = true;
            addStudent_Button.Click += addStudent_Button_Click;
            // 
            // deleteStudent_Button
            // 
            deleteStudent_Button.Location = new Point(51, 212);
            deleteStudent_Button.Name = "deleteStudent_Button";
            deleteStudent_Button.Size = new Size(129, 23);
            deleteStudent_Button.TabIndex = 6;
            deleteStudent_Button.Text = "Delete student";
            deleteStudent_Button.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudentClasses
            // 
            dataGridViewStudentClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentClasses.Location = new Point(658, 48);
            dataGridViewStudentClasses.Name = "dataGridViewStudentClasses";
            dataGridViewStudentClasses.Size = new Size(130, 390);
            dataGridViewStudentClasses.TabIndex = 7;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = backToMenu_button;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewStudentClasses);
            Controls.Add(deleteStudent_Button);
            Controls.Add(addStudent_Button);
            Controls.Add(searchComboBox);
            Controls.Add(searchTextBox);
            Controls.Add(search_Button);
            Controls.Add(dataGridViewStudents);
            Controls.Add(backToMenu_button);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += StudentForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMenu_button;
        private DataGridView dataGridViewStudents;
        private Button search_Button;
        private TextBox searchTextBox;
        private ComboBox searchComboBox;
        private Button addStudent_Button;
        private Button deleteStudent_Button;
        private DataGridView dataGridViewStudentClasses;
    }
}