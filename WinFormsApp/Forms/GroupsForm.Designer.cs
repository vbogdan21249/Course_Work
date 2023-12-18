namespace WinFormsApp.Forms
{
    partial class GroupsForm
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
            backToMenu_button = new Button();
            dataGridViewClasses = new DataGridView();
            SearchComboBox = new ComboBox();
            searchTextBox = new TextBox();
            search_Button = new Button();
            deleteStudent_Button = new Button();
            addStudent_Button = new Button();
            addClass_Button = new Button();
            dataGridViewStudents = new DataGridView();
            Refresh_Button = new Button();
            deleteClass_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // backToMenu_button
            // 
            backToMenu_button.Location = new Point(12, 415);
            backToMenu_button.Name = "backToMenu_button";
            backToMenu_button.Size = new Size(75, 23);
            backToMenu_button.TabIndex = 1;
            backToMenu_button.Text = "Back";
            backToMenu_button.UseVisualStyleBackColor = true;
            backToMenu_button.Click += backToMenu_button_Click;
            // 
            // dataGridViewClasses
            // 
            dataGridViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClasses.Location = new Point(178, 82);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.Size = new Size(143, 301);
            dataGridViewClasses.TabIndex = 2;
            dataGridViewClasses.CellClick += dataGridViewClasses_CellClick;
            // 
            // SearchComboBox
            // 
            SearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Items.AddRange(new object[] { "ID", "Name", "Surname", "Patronymic", "Class", "Dormitory", "Room" });
            SearchComboBox.Location = new Point(341, 26);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(90, 23);
            SearchComboBox.TabIndex = 7;
            SearchComboBox.Tag = "";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(437, 26);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(174, 23);
            searchTextBox.TabIndex = 6;
            // 
            // search_Button
            // 
            search_Button.Location = new Point(617, 25);
            search_Button.Name = "search_Button";
            search_Button.Size = new Size(75, 23);
            search_Button.TabIndex = 5;
            search_Button.Text = "Search";
            search_Button.UseVisualStyleBackColor = true;
            search_Button.Click += search_Button_Click;
            // 
            // deleteStudent_Button
            // 
            deleteStudent_Button.Location = new Point(476, 389);
            deleteStudent_Button.Name = "deleteStudent_Button";
            deleteStudent_Button.Size = new Size(129, 23);
            deleteStudent_Button.TabIndex = 9;
            deleteStudent_Button.Text = "Delete student";
            deleteStudent_Button.UseVisualStyleBackColor = true;
            deleteStudent_Button.Click += deleteStudent_Button_Click;
            // 
            // addStudent_Button
            // 
            addStudent_Button.Location = new Point(341, 389);
            addStudent_Button.Name = "addStudent_Button";
            addStudent_Button.Size = new Size(129, 23);
            addStudent_Button.TabIndex = 8;
            addStudent_Button.Text = "Add student";
            addStudent_Button.UseVisualStyleBackColor = true;
            addStudent_Button.Click += addStudent_Button_Click;
            // 
            // addClass_Button
            // 
            addClass_Button.Location = new Point(178, 26);
            addClass_Button.Name = "addClass_Button";
            addClass_Button.Size = new Size(104, 23);
            addClass_Button.TabIndex = 10;
            addClass_Button.Text = "Add class";
            addClass_Button.UseVisualStyleBackColor = true;
            addClass_Button.Click += addClass_Button_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(341, 64);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(447, 319);
            dataGridViewStudents.TabIndex = 3;
            // 
            // Refresh_Button
            // 
            Refresh_Button.Location = new Point(288, 26);
            Refresh_Button.Name = "Refresh_Button";
            Refresh_Button.Size = new Size(24, 23);
            Refresh_Button.TabIndex = 11;
            Refresh_Button.Text = "⟳";
            Refresh_Button.UseVisualStyleBackColor = true;
            Refresh_Button.Click += Refresh_Button_Click;
            // 
            // deleteClass_Button
            // 
            deleteClass_Button.Location = new Point(178, 55);
            deleteClass_Button.Name = "deleteClass_Button";
            deleteClass_Button.Size = new Size(104, 23);
            deleteClass_Button.TabIndex = 12;
            deleteClass_Button.Text = "Delete class";
            deleteClass_Button.UseVisualStyleBackColor = true;
            deleteClass_Button.Click += deleteClass_Button_Click;
            // 
            // GroupsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = backToMenu_button;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteClass_Button);
            Controls.Add(Refresh_Button);
            Controls.Add(addClass_Button);
            Controls.Add(deleteStudent_Button);
            Controls.Add(addStudent_Button);
            Controls.Add(SearchComboBox);
            Controls.Add(searchTextBox);
            Controls.Add(search_Button);
            Controls.Add(dataGridViewStudents);
            Controls.Add(dataGridViewClasses);
            Controls.Add(backToMenu_button);
            Name = "GroupsForm";
            Text = "Groups";
            FormClosed += GroupsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMenu_button;
        private DataGridView dataGridViewClasses;
        private ComboBox SearchComboBox;
        private TextBox searchTextBox;
        private Button search_Button;
        private Button deleteStudent_Button;
        private Button addStudent_Button;
        private Button addClass_Button;
        private DataGridView dataGridViewStudents;
        private Button Refresh_Button;
        private Button deleteClass_Button;
    }
}