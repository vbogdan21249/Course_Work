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

namespace WinFormsApp.Forms
{
    public partial class GroupsForm : Form
    {
        BindingSource studentBindingSource = new BindingSource();
        BindingSource classesBindingSource = new BindingSource();
        StudentsDAO studentsDAO = new StudentsDAO();
        StudentsDAO classesDAO = new StudentsDAO();

        public GroupsForm()
        {
            InitializeComponent();
            //InitializeDataGridViewStudents();

            SearchComboBox.SelectedIndex = 0;
            dataGridViewStudents.DataSource = studentsDAO.getAllStudents();
            classesBindingSource.DataSource = classesDAO.getAllClasses();

            dataGridViewClasses.DataSource = classesBindingSource;
            dataGridViewClasses.Columns[0].Visible = false;
        }

        //private void InitializeDataGridViewStudents()
        //{
        //    DataTable dtStudents = studentsDAO.GetStudentsData();

        //    // Замена Class_ID на Name, Dormitory_ID на Dormitor_Number, Room_ID на Room_Number
        //    DataColumn classNameColumn = dtStudents.Columns.Add("ClassName", typeof(string));
        //    DataColumn dormNumberColumn = dtStudents.Columns.Add("DormNumber", typeof(string));
        //    DataColumn roomNumberColumn = dtStudents.Columns.Add("RoomNumber", typeof(string));

        //    foreach (DataRow row in dtStudents.Rows)
        //    {
        //        // Заполнение новых колонок данными из соответствующих таблиц
        //        row["ClassName"] = studentsDAO.GetClassName(Convert.ToInt32(row["Class_ID"]));
        //        row["DormNumber"] = studentsDAO.GetDormitoryNumber(Convert.ToInt32(row["Dormitory_ID"]));
        //        row["RoomNumber"] = studentsDAO.GetRoomNumber(Convert.ToInt32(row["Room_ID"]));
        //    }

        //    // Удаление старых колонок
        //    dtStudents.Columns.Remove("Class_ID");
        //    dtStudents.Columns.Remove("Dormitory_ID");
        //    dtStudents.Columns.Remove("Room_ID");

        //    // Отображение данных на DataGridView
        //    dataGridViewStudents.DataSource = dtStudents;
        //}


        private void backToMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void dataGridViewClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowClicked = dataGridViewClasses.CurrentRow.Index;
            StudentsDAO studentsDAO = new StudentsDAO();
            if (rowClicked == dataGridViewClasses.Rows.Count - 1)
            {
                dataGridViewStudents.DataSource = studentsDAO.getAllStudents();
            }
            else
            {
                studentBindingSource.DataSource = studentsDAO.getStudentsForClass((int)dataGridViewClasses.Rows[rowClicked].Cells[0].Value);
                dataGridViewStudents.DataSource = studentBindingSource;
            }
        }

        private void GroupsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewClasses.CurrentRow.Index;
            MessageBox.Show("Row selected: " + rowClicked);
            StudentsDAO studentsDAO = new StudentsDAO();
            studentBindingSource.DataSource = studentsDAO.searchTitles(searchTextBox.Text, SearchComboBox);
            dataGridViewStudents.DataSource = studentBindingSource;
        }

        private void addStudent_Button_Click(object sender, EventArgs e)
        {
            AddingStudentForm addingStudentForm = new AddingStudentForm();
            addingStudentForm.Show();
        }

        private void deleteStudent_Button_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewStudents.CurrentRow.Index;
            int studentID = (int)dataGridViewStudents.Rows[rowClicked].Cells[0].Value;
            studentsDAO.deleteStudent(studentID);

            //dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = studentsDAO.getAllStudents();
            //deleteStudent_Button.Enabled = false;

        }
        private void deleteClass_Button_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewClasses.CurrentRow.Index;

            int classID = (int)dataGridViewClasses.Rows[rowClicked].Cells[0].Value;
            studentsDAO.deleteClass(classID);

            dataGridViewStudents.DataSource = studentsDAO.getAllStudents();
            //deleteStudent_Button.Enabled = false;
        }

        private void addClass_Button_Click(object sender, EventArgs e)
        {
            AddingClassForm addingStudentForm = new AddingClassForm();
            addingStudentForm.Show();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = studentsDAO.getAllStudents();
            classesBindingSource.DataSource = classesDAO.getAllClasses();
            dataGridViewClasses.Columns[0].Visible = false;
        }


    }
}
