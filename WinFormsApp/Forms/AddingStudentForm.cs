using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp.Forms
{
    public partial class AddingStudentForm : Form
    {
        public AddingStudentForm()
        {
            InitializeComponent();
            ClassComboBox.SelectedIndex = ClassComboBox.Items.Count - 1;
            DormitoryComboBox.SelectedIndex = 0;
        }
        
        private void dormitoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DormitoryComboBox.Enabled = dormitoryCheckBox.Checked;
            RoomComboBox.Enabled = dormitoryCheckBox.Checked;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FirstName = txt_Name.Text,
                SecondName = txt_Surname.Text,
                ThirdName = txt_Patronymic.Text,
                Class_ID = ClassComboBox.SelectedIndex,
                Dormitory_ID = (dormitoryCheckBox.Checked) ? DormitoryComboBox.SelectedIndex : null,
                Room_ID = (dormitoryCheckBox.Checked) ? DormitoryComboBox.SelectedIndex : null,
                //ClassNumber = ClassComboBox.Text,
                //DormitoryNumber = (dormitoryCheckBox.Checked) ? Convert.ToInt32(DormitoryComboBox.SelectedItem) : 0,
                //RoomNumber = (dormitoryCheckBox.Checked) ? Convert.ToInt32(RoomComboBox.SelectedItem) : 0
            };
            StudentsDAO studentsDAO = new StudentsDAO();
            int result = studentsDAO.addStudent(student);
            MessageBox.Show(result + " new row(s) inserted");
        }
    }
}
