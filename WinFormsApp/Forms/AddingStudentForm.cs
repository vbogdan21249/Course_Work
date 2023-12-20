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

            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            StudentsDAO studentsDAO = new StudentsDAO(); ;

            ClassComboBox.DataSource = studentsDAO.GetClassesData();
            ClassComboBox.DisplayMember = "Name";
            ClassComboBox.ValueMember = "ID";
            ClassComboBox.SelectedIndex = 0;


            DormitoryComboBox.DataSource = studentsDAO.GetDormitoryData();
            DormitoryComboBox.DisplayMember = "Dormitory_Number";
            DormitoryComboBox.ValueMember = "ID";
            DormitoryComboBox.SelectedIndex = 0;

            RoomComboBox.DataSource = studentsDAO.GetRoomsData(Convert.ToInt32(DormitoryComboBox.SelectedValue));
            RoomComboBox.DisplayMember = "Room_Number";
            RoomComboBox.ValueMember = "ID";
            RoomComboBox.SelectedIndex = 0;
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
                Class_ID = (dormitoryCheckBox.Checked == true) ? ClassComboBox_selectedID() : null,
                Dormitory_ID = (dormitoryCheckBox.Checked == true) ? DormitoryComboBox_selectedID() : null,
                Room_ID = (dormitoryCheckBox.Checked == true) ? RoomComboBox_selectedID() : null
            };
            StudentsDAO studentsDAO = new StudentsDAO();
            studentsDAO.addStudent(student);


        }

        private void AddingStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassComboBox.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)ClassComboBox.SelectedItem;
                Convert.ToInt32(selectedRow["ID"]);
            }
        }

        private void DormitoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassComboBox.SelectedItem != null)
            {

                DataRowView selectedRow = (DataRowView)DormitoryComboBox.SelectedItem;
                int selectedID = Convert.ToInt32(selectedRow["ID"]);
                StudentsDAO studentsDAO = new StudentsDAO();
                RoomComboBox.DataSource = studentsDAO.GetRoomsData(selectedID);

            }

        }

        private void RoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)RoomComboBox.SelectedItem;
            int selectedID = Convert.ToInt32(selectedRow["ID"]);
            StudentsDAO studentsDAO = new StudentsDAO();
            RoomComboBox.DataSource = studentsDAO.GetRoomsData(selectedID);
        }

        private int ClassComboBox_selectedID()
        {
            DataRowView selectedRow = (DataRowView)ClassComboBox.SelectedItem;
            int selectedID = Convert.ToInt32(selectedRow["ID"]);
            return selectedID;
        }

        private int DormitoryComboBox_selectedID()
        {
            DataRowView selectedRow = (DataRowView)DormitoryComboBox.SelectedItem;
            int selectedID = Convert.ToInt32(selectedRow["ID"]);
            return selectedID;
        }

        private int? RoomComboBox_selectedID()
        {
            DataRowView selectedRow = (DataRowView)RoomComboBox.SelectedItem;
            int selectedID = Convert.ToInt32(selectedRow["ID"]);
            return selectedID;
        }

    }
}
