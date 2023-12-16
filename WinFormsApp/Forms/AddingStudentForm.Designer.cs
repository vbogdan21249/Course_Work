namespace WinFormsApp.Forms
{
    partial class AddingStudentForm
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
            ClassComboBox = new ComboBox();
            add_Button = new Button();
            Cancel_Button = new Button();
            groupBox1 = new GroupBox();
            RoomComboBox = new ComboBox();
            DormitoryComboBox = new ComboBox();
            dormitoryCheckBox = new CheckBox();
            txt_Patronymic = new TextBox();
            txt_Surname = new TextBox();
            txt_Name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ClassComboBox
            // 
            ClassComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Items.AddRange(new object[] { "A1", "A2", "B1", "B2", "C1", "C2", "QQ" });
            ClassComboBox.Location = new Point(172, 64);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(60, 23);
            ClassComboBox.TabIndex = 9; 
            // 
            // add_Button
            // 
            add_Button.Location = new Point(326, 293);
            add_Button.Name = "add_Button";
            add_Button.Size = new Size(75, 23);
            add_Button.TabIndex = 0;
            add_Button.Text = "Add";
            add_Button.UseVisualStyleBackColor = true;
            add_Button.Click += add_Button_Click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Location = new Point(12, 293);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(75, 23);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = true;
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RoomComboBox);
            groupBox1.Controls.Add(DormitoryComboBox);
            groupBox1.Controls.Add(ClassComboBox);
            groupBox1.Controls.Add(dormitoryCheckBox);
            groupBox1.Controls.Add(txt_Patronymic);
            groupBox1.Controls.Add(txt_Surname);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 275);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding Student";
            // 
            // RoomComboBox
            // 
            RoomComboBox.Enabled = false;
            RoomComboBox.FormattingEnabled = true;
            RoomComboBox.Location = new Point(260, 150);
            RoomComboBox.Name = "RoomComboBox";
            RoomComboBox.Size = new Size(80, 23);
            RoomComboBox.TabIndex = 11;
            // 
            // DormitoryComboBox
            // 
            DormitoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DormitoryComboBox.Enabled = false;
            DormitoryComboBox.FormattingEnabled = true;
            DormitoryComboBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            DormitoryComboBox.Location = new Point(172, 150);
            DormitoryComboBox.Name = "DormitoryComboBox";
            DormitoryComboBox.Size = new Size(82, 23);
            DormitoryComboBox.TabIndex = 10;
            // 
            // dormitoryCheckBox
            // 
            dormitoryCheckBox.AutoSize = true;
            dormitoryCheckBox.Location = new Point(239, 119);
            dormitoryCheckBox.Name = "dormitoryCheckBox";
            dormitoryCheckBox.Size = new Size(15, 14);
            dormitoryCheckBox.TabIndex = 8;
            dormitoryCheckBox.UseVisualStyleBackColor = true;
            dormitoryCheckBox.CheckedChanged += dormitoryCheckBox_CheckedChanged;
            // 
            // txt_Patronymic
            // 
            txt_Patronymic.Location = new Point(13, 176);
            txt_Patronymic.Name = "txt_Patronymic";
            txt_Patronymic.Size = new Size(100, 23);
            txt_Patronymic.TabIndex = 7;
            // 
            // txt_Surname
            // 
            txt_Surname.Location = new Point(13, 118);
            txt_Surname.Name = "txt_Surname";
            txt_Surname.Size = new Size(100, 23);
            txt_Surname.TabIndex = 6;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(13, 64);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(100, 23);
            txt_Name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 118);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Dormitory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 46);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 158);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Patronymic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // AddingStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 325);
            Controls.Add(groupBox1);
            Controls.Add(Cancel_Button);
            Controls.Add(add_Button);
            Name = "AddingStudentForm";
            Text = "AddingStudentForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button add_Button;
        private Button Cancel_Button;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txt_Name;
        private ComboBox RoomComboBox;
        private ComboBox DormitoryComboBox;
        private ComboBox ClassComboBox;
        private CheckBox dormitoryCheckBox;
        private TextBox txt_Patronymic;
        private TextBox txt_Surname;
    }
}