using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.ActiveControl = student_Button;
        }

        private void student_Button_Click(object sender, EventArgs e)
        {
            Hide();
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }
        private void group_Button_Click(object sender, EventArgs e)
        {
            Hide();
            GroupsForm groupsForm = new GroupsForm();
            groupsForm.Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        
    }
}
