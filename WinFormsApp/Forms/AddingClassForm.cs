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
    public partial class AddingClassForm : Form
    {
        public AddingClassForm()
        {
            InitializeComponent();
            StudentsDAO studentsDAO = new StudentsDAO();
            dataGridViewUnallocatedStudents.DataSource = studentsDAO.GetQQStudents();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void add_Button_Click(object sender, EventArgs e)
        {
            Class classes = new Class
            {
                Name = txt_Name.Text,
            };

            StudentsDAO studentsDAO = new StudentsDAO();
            studentsDAO.addClass(classes);

        }

        private void AddingClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

    }
}
