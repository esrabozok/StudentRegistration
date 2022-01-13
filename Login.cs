namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            new Baglanti();
        }

        private void userTxt_Validating(object sender, CancelEventArgs e)
        {
            if (userVal.Visible = string.IsNullOrEmpty(userTxt.Text))
                e.Cancel = true;
        }

        private void passwordTxt_Validating(object sender, CancelEventArgs e)
        {
            if (passwordVal.Visible = string.IsNullOrEmpty(passwordTxt.Text))
            {
                e.Cancel = true;
            }
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            userVal.Visible = string.IsNullOrEmpty(userTxt.Text);
            passwordVal.Visible = string.IsNullOrEmpty(passwordTxt.Text);
            if (userVal.Visible || passwordVal.Visible)
            {
                return;
            }

            string command = "Select * From [User] Where UserName = @user and Password = @password";

            var result = Baglanti.Select(command, new List<SqlParameter>() { new SqlParameter("@user", userTxt.Text), new SqlParameter("@password", passwordTxt.Text) });
            girisVal.Visible = result.Rows.Count == 0;
            if (!girisVal.Visible)
            {
                Int32.TryParse(result.Rows[0]["UserType"].ToString(), out int tipi);
                Int32.TryParse(result.Rows[0]["UserId"].ToString(), out int id);
                this.Hide();
                switch ((UserType)tipi)
                {
                    case UserType.Student:
                        StudentForm StudentForm = new StudentForm(id);
                        this.Hide();
                        StudentForm.ShowDialog();
                        break;
                    case UserType.Instructor:
                        InstructorForm InstructorForm = new InstructorForm(id);
                        this.Hide();
                        InstructorForm.ShowDialog();
                        break;
                    case UserType.Admin:
                        AdminForm AdminForm = new AdminForm();
                        AdminForm.ShowDialog();
                        break;
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
