using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class StudentForm : Form
    {
        BindingSource studentBindingSource = new BindingSource();
        public StudentForm()
        {
            InitializeComponent();
            StudentsDAO studentsDAO = new StudentsDAO();
            studentBindingSource.DataSource = studentsDAO.getAllStudents();
            dataGridViewStudents.DataSource = studentBindingSource;
            searchComboBox.SelectedIndex = 0;
            dataGridViewStudents.Columns[4].Visible = false;
            dataGridViewStudents.Columns[5].Visible = false;
            dataGridViewStudents.Columns[6].Visible = false;
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            StudentsDAO studentsDAO = new StudentsDAO();
            studentBindingSource.DataSource = studentsDAO.searchTitles(searchTextBox.Text, searchComboBox);
            dataGridViewStudents.DataSource = studentBindingSource;
        }
        private void backToMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();

        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowClicked = dataGridViewStudents.CurrentRow.Index;
            StudentsDAO studentsDAO = new StudentsDAO();
            //if (rowClicked == dataGridViewStudents.Rows.Count - 1)
            //{
            //    dataGridViewStudents.DataSource = studentsDAO.getAllStudents();
            //}
            //else
            //{
            //    studentBindingSource.DataSource = studentsDAO.getClassesForStudent((int)dataGridViewStudents.Rows[rowClicked].Cells[0].Value);
            //    dataGridViewStudents.DataSource = studentBindingSource;
            //}

        }

        private void addStudent_Button_Click(object sender, EventArgs e)
        {
            AddingStudentForm addingStudentForm = new AddingStudentForm();
            addingStudentForm.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
