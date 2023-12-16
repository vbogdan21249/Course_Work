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
            dataGridViewStudents = new DataGridView();
            searchComboBox = new ComboBox();
            searchTextBox = new TextBox();
            search_Button = new Button();
            deleteStudent_Button = new Button();
            addStudent_Button = new Button();
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
            dataGridViewClasses.Location = new Point(178, 64);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.Size = new Size(143, 319);
            dataGridViewClasses.TabIndex = 2;
            dataGridViewClasses.CellClick += dataGridViewClasses_CellClick;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(341, 64);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(447, 319);
            dataGridViewStudents.TabIndex = 3;
            // 
            // searchComboBox
            // 
            searchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "ID", "Name", "Surname", "Patronymic" });
            searchComboBox.Location = new Point(341, 26);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(90, 23);
            searchComboBox.TabIndex = 7;
            searchComboBox.Tag = "";
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
            deleteStudent_Button.Location = new Point(26, 209);
            deleteStudent_Button.Name = "deleteStudent_Button";
            deleteStudent_Button.Size = new Size(129, 23);
            deleteStudent_Button.TabIndex = 9;
            deleteStudent_Button.Text = "Delete student";
            deleteStudent_Button.UseVisualStyleBackColor = true;
            // 
            // addStudent_Button
            // 
            addStudent_Button.Location = new Point(26, 180);
            addStudent_Button.Name = "addStudent_Button";
            addStudent_Button.Size = new Size(129, 23);
            addStudent_Button.TabIndex = 8;
            addStudent_Button.Text = "Add student";
            addStudent_Button.UseVisualStyleBackColor = true;
            addStudent_Button.Click += addStudent_Button_Click;
            // 
            // GroupsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = backToMenu_button;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteStudent_Button);
            Controls.Add(addStudent_Button);
            Controls.Add(searchComboBox);
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
        private DataGridView dataGridViewStudents;
        private ComboBox searchComboBox;
        private TextBox searchTextBox;
        private Button search_Button;
        private Button deleteStudent_Button;
        private Button addStudent_Button;
    }
}