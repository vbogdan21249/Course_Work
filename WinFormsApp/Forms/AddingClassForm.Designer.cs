namespace WinFormsApp.Forms
{
    partial class AddingClassForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            add_Button = new Button();
            Cancel_Button = new Button();
            label2 = new Label();
            dataGridViewUnallocatedStudents = new DataGridView();
            txt_Name = new TextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnallocatedStudents).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(add_Button);
            groupBox1.Controls.Add(Cancel_Button);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridViewUnallocatedStudents);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 275);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding Class";
            // 
            // add_Button
            // 
            add_Button.Location = new Point(6, 77);
            add_Button.Name = "add_Button";
            add_Button.Size = new Size(75, 23);
            add_Button.TabIndex = 10;
            add_Button.Text = "Add";
            add_Button.UseVisualStyleBackColor = true;
            add_Button.Click += add_Button_Click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Location = new Point(6, 246);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(75, 23);
            Cancel_Button.TabIndex = 9;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = true;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 30);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 7;
            label2.Text = "Unallocated students";
            // 
            // dataGridViewUnallocatedStudents
            // 
            dataGridViewUnallocatedStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnallocatedStudents.Location = new Point(161, 48);
            dataGridViewUnallocatedStudents.Name = "dataGridViewUnallocatedStudents";
            dataGridViewUnallocatedStudents.Size = new Size(222, 221);
            dataGridViewUnallocatedStudents.TabIndex = 6;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(6, 48);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(100, 23);
            txt_Name.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // AddingClassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 295);
            Controls.Add(groupBox1);
            Name = "AddingClassForm";
            Text = "AddingClassForm";
            FormClosed += AddingClassForm_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnallocatedStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private DataGridView dataGridViewUnallocatedStudents;
        private TextBox txt_Name;
        private Label label1;
        private Button Cancel_Button;
        private Button add_Button;
        private ImageList imageList1;
    }
}