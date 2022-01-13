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

    public partial class TestService : Form
    {
        public TestService()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select("Select s.StudentId, s.Name,s.Surname, u.UserName, u.Password, s.UserId, s.Adress, s.Phone, s.BloodType, s.Email, s.BirthDate, s.EntryDate, s.Gender From Student s inner join [User] u on s.UserId = u.UserId Where s.Gender = @gender And s.BirthDate<@date", new List<SqlParameter> {
                        new SqlParameter("@gender", "Male"), new SqlParameter("@date", DateTime.Now.AddYears(-30)) });
            dataGridView1.DataSource = dataTable;
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            studentIdTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nameTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surnameTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            userNameTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            passwordTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            userIdTB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            adressTB.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            phoneTB.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            bloodTypeTB.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            emailTB.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            var birth = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            var entry = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            genderTB.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            if (!string.IsNullOrEmpty(birth))
                birthDatePicker.Value = DateTime.Parse(birth);
            if (!string.IsNullOrEmpty(entry))
                entryDatePicker.Value = DateTime.Parse(entry);
        }
    }
}
