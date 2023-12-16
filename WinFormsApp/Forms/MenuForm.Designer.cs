namespace WinFormsApp
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            student_Button = new Button();
            group_Button = new Button();
            dorms_Button = new Button();
            search_Button = new Button();
            SuspendLayout();
            // 
            // student_Button
            // 
            student_Button.Location = new Point(363, 144);
            student_Button.Name = "student_Button";
            student_Button.Size = new Size(75, 23);
            student_Button.TabIndex = 4;
            student_Button.Text = "Students";
            student_Button.UseVisualStyleBackColor = true;
            student_Button.Click += student_Button_Click;
            // 
            // group_Button
            // 
            group_Button.Location = new Point(363, 173);
            group_Button.Name = "group_Button";
            group_Button.Size = new Size(75, 23);
            group_Button.TabIndex = 1;
            group_Button.Text = "Groups";
            group_Button.UseVisualStyleBackColor = true;
            group_Button.Click += group_Button_Click;
            // 
            // dorms_Button
            // 
            dorms_Button.Location = new Point(363, 202);
            dorms_Button.Name = "dorms_Button";
            dorms_Button.Size = new Size(75, 23);
            dorms_Button.TabIndex = 2;
            dorms_Button.Text = "Dorms";
            dorms_Button.UseVisualStyleBackColor = true;
            // 
            // search_Button
            // 
            search_Button.Location = new Point(363, 231);
            search_Button.Name = "search_Button";
            search_Button.Size = new Size(75, 23);
            search_Button.TabIndex = 3;
            search_Button.Text = "Search";
            search_Button.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(student_Button);
            Controls.Add(search_Button);
            Controls.Add(dorms_Button);
            Controls.Add(group_Button);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dean's Office";
            FormClosed += MenuForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private Button group_Button;
        private Button dorms_Button;
        private Button search_Button;
        private Button student_Button;
    }
}
