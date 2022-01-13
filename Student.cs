namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class Student : Form
    {
        public Student()
        {

            InitializeComponent();
            var command = "Select * From [Instructor]";
            var sonuc = Baglanti.Select(command, new List<SqlParameter>());
            comboBox3.DataSource = sonuc;
            comboBox3.ValueMember = "InstructorId";
            comboBox3.DisplayMember = "Name";
            Refresh();
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
            var advisor = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            if (!string.IsNullOrEmpty(birth))
                birthDatePicker.Value = DateTime.Parse(birth);
            if (!string.IsNullOrEmpty(entry))
                entryDatePicker.Value = DateTime.Parse(entry);
            if (int.TryParse(advisor, out int advisorId))
                comboBox3.SelectedValue = advisorId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboBox3?.SelectedValue.ToString()))
            {
                MessageBox.Show("Danışman seçiniz ");
                return;
            }

            string command = "Insert into [User] (UserName,Password,UserType) values (@userName,@password,1)";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@userName", userNameTB.Text), new SqlParameter("@password", passwordTB.Text) });
            if (result > 0)
            {
                command = "Select * From [User] Where UserName=@userName";
                var sonuc = Baglanti.Select(command, new List<SqlParameter> { new SqlParameter("@userName", userNameTB.Text) });
                if (Int32.TryParse(sonuc.Rows[0]["UserId"].ToString(), out int userId))
                {
                    command = "Insert into Student (Name,Surname,Adress,Phone,BloodType,Email,BirthDate,EntryDate,Gender,UserId,ConsultantId) values (@name, @surname, @adress, @phone, @bloodType, @email, @birthDate, @entryDate, @gender, @userId, @advisorId)";
                    Baglanti.InsertOrUpdate(command, new List<SqlParameter> {
                        new SqlParameter("@name", nameTB.Text),
                        new SqlParameter("@surname", surnameTB.Text),
                        new SqlParameter("@adress", adressTB.Text),
                        new SqlParameter("@phone", phoneTB.Text),
                        new SqlParameter("@bloodType", bloodTypeTB.Text),
                        new SqlParameter("@email", emailTB.Text),
                        new SqlParameter("@birthDate", birthDatePicker.Value),
                        new SqlParameter("@entryDate", entryDatePicker.Value),
                        new SqlParameter("@gender", genderTB.Text),
                        new SqlParameter("@userId", userId),
                        new SqlParameter("@advisorId", (int)comboBox3.SelectedValue)});
                    Refresh();
                }
            }
        }

        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select("Select s.StudentId, s.Name,s.Surname, u.UserName, u.Password, s.UserId, s.Adress, s.Phone, s.BloodType, s.Email, s.BirthDate, s.EntryDate, s.Gender, s.AdvisorId From Student s inner join [User] u on s.UserId = u.UserId", null);
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string command = "Update [User] Set UserName = @userName, Password= @password Where UserId = @id";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> {new SqlParameter("@userName", userNameTB.Text),
                new SqlParameter("@password", passwordTB.Text), new SqlParameter("@id", userIdTB.Text)});
            if (result > 0)
            {
                command = "Update Student Set Name = @name, Surname= @surname, Adress=@adress, Phone= @phone, BloodType=@bloodType, Email= @email, BirthDate = @birthDate, EntryDate = @entryDate, Gender= @gender, AdvisorId = @advisorId Where StudentId = @id";
                result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> {new SqlParameter("@name", nameTB.Text),
                new SqlParameter("@surname", surnameTB.Text),
                new SqlParameter("@adress", adressTB.Text),
                new SqlParameter("@phone", phoneTB.Text),
                new SqlParameter("@bloodType", bloodTypeTB.Text),
                new SqlParameter("@email", emailTB.Text),
                new SqlParameter("@birthDate", birthDatePicker.Value),
                new SqlParameter("@entryDate", entryDatePicker.Value),
                new SqlParameter("@gender", genderTB.Text),
                new SqlParameter("@id", studentIdTB.Text),
                new SqlParameter("@advisorId", (int)comboBox3.SelectedValue)});

                Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string command = "Delete [User] Where UserId = @id";
            var res = MessageBox.Show("Do you want delete?", "Confirm", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", userIdTB.Text) });
            if (result > 0)
            {
                command = "Delete Student Where StudentId = @id";
                result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", studentIdTB.Text) });
                Refresh();
            }
        }
    }
}
