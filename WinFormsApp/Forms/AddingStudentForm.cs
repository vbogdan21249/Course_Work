using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp.Forms
{
    public partial class AddingStudentForm : Form
    {
        public AddingStudentForm()
        {
            InitializeComponent();
            InitializeComboBox();

            DormitoryComboBox.SelectedIndex = 0;
        }
        private void InitializeComboBox()
        {
            StudentsDAO studentsDAO = new StudentsDAO();
            DataTable dtClasses = studentsDAO.GetClassesData();
            ClassComboBox.DataSource = dtClasses;
            ClassComboBox.DisplayMember = "Name";
            ClassComboBox.ValueMember = "ID";
            ClassComboBox.SelectedIndex = 0;
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

            };
            StudentsDAO studentsDAO = new StudentsDAO();
            int result = studentsDAO.addStudent(student);
            MessageBox.Show(result + " new row(s) inserted");
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassComboBox.SelectedItem != null)
            {
                
                DataRowView selectedRow = (DataRowView)ClassComboBox.SelectedItem;
                int selectedID = Convert.ToInt32(selectedRow["ID"]);

            }
        }

        private void AddingStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
