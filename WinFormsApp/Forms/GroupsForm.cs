using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Forms
{
    public partial class GroupsForm : Form
    {
        BindingSource studentBindingSource = new BindingSource();
        BindingSource classesBindingSource = new BindingSource();
        public GroupsForm()
        {
            InitializeComponent();

            StudentsDAO studentsDAO = new StudentsDAO();
            StudentsDAO classesDAO = new StudentsDAO();
            searchComboBox.SelectedIndex = 0;
            dataGridViewStudents.DataSource = studentsDAO.getAllStudents();
            classesBindingSource.DataSource = classesDAO.getAllClasses();
            dataGridViewClasses.DataSource = classesBindingSource;
            dataGridViewClasses.Columns[0].Visible = false;
        }

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
            StudentsDAO studentsDAO = new StudentsDAO();
            studentBindingSource.DataSource = studentsDAO.searchTitles(searchTextBox.Text, searchComboBox);
            dataGridViewStudents.DataSource = studentBindingSource;
        }

        private void addStudent_Button_Click(object sender, EventArgs e)
        {
                AddingStudentForm addingStudentForm = new AddingStudentForm();
                addingStudentForm.Show();  
        }
    }
}
