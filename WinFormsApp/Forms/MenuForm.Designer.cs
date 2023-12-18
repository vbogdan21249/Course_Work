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
            group_Button = new Button();
            dorms_Button = new Button();
            SuspendLayout();
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
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
