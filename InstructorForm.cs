namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class InstructorForm : Form
    {
        string instructorCourseId = "";
        public InstructorForm(int userId)
        {
            InitializeComponent();
            GetInstructors(userId);
            GetSemesterCourses();
            FillCourses();
            FillSemesters();
        }

        private void GetInstructors(int userId)
        {
            DataTable dataTable = Baglanti.Select("Select s.InstructorId, s.Name,s.Surname, u.UserName, u.Password, s.UserId, s.Adress, s.Phone, s.BloodType, s.Email, s.BirthDate, s.EntryDate From Instructor s inner join [User] u on s.UserId = u.UserId Where u.UserId = @userId", new List<SqlParameter>() { new SqlParameter("@userId", userId) });

            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                instructorIdTB.Text = row["InstructorId"].ToString();
                nameTB.Text = row["Name"].ToString();
                surnameTB.Text = row["Surname"].ToString();
                userNameTB.Text = row["UserName"].ToString();
                //textBox5.Text = row["Password"].ToString();
                userIdTB.Text = row["UserId"].ToString();
                adressTB.Text = row["Adress"].ToString();
                phoneTB.Text = row["Phone"].ToString();
                emailTB.Text = row["Email"].ToString();
                bloodTypeTB.Text = row["BloodType"].ToString();

                birthDatePicker.Text = row["BirthDate"].ToString();
                entryDatePicker.Text = row["EntryDate"].ToString();

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            instructorCourseId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void GetSemesterCourses(int? semesterId = null)
        {
            var sql = "Select sc.SemesterCourseId, s.Year, s.SemesterType, c.Name From SemesterCourse sc inner join Course c on sc.CourseId = c.CourseId inner join Semester s on s.SemesterId = sc.SemesterId Where sc.InstructorId = @userId";

            var list = new List<SqlParameter>() { new SqlParameter("@userId", instructorIdTB.Text) };
            if (semesterId.HasValue)
            {
                sql += " and sc.SemesterId = @semesterId";
                list.Add(new SqlParameter("@semesterId", semesterId.Value));
            }
            DataTable dataTable = Baglanti.Select(sql, list);
            dataGridView1.DataSource = dataTable;
            instructorCourseId = string.Empty;
        }

        private void FillCourses()
        {
            comboBox1.Text = "Select Course";
            DataTable dataTable = Baglanti.Select("Select * From Course", null);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CourseId";
        }

        private void FillSemesters()
        {
            DataTable dataTable = Baglanti.Select("Select * From Semester", null);
            dataTable.Columns.Add("SemesterFull", typeof(string), "Year + ' ' + SemesterType");
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "SemesterFull";
            comboBox2.ValueMember = "SemesterId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTB.Text))
            {
                MessageBox.Show("Password boş olamaz");
                return;
            }

            string command = "Update [User] Set Password= @password Where UserId = @id";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@password", passwordTB.Text), new SqlParameter("@id", userIdTB.Text) });
            if (result > 0)
                MessageBox.Show("Password changed.");
            else
                MessageBox.Show("Password didint changed.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Choose course from the list");
                return;
            }
            var courseId = ((DataRowView)comboBox1.SelectedItem).Row[0].ToString();
            if (comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Select semester from the list");
                return;
            }
            var canAdd = bool.Parse(((DataRowView)comboBox2.SelectedItem).Row[3].ToString());
            if(!canAdd)
            {
                MessageBox.Show("Course cannot add to selected semester.");
                return;
            }
            var semesterId = ((DataRowView)comboBox2.SelectedItem).Row[0].ToString();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value?.ToString() == courseId)
                {
                    MessageBox.Show("Course is already added.");
                    return;
                }
            }

            string command = "Insert into SemesterCourse (SemesterId, CourseId, InstructorId) values (@semesterId, @courseId, @instructorId)";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@semesterId", semesterId), new SqlParameter("@courseId", courseId), new SqlParameter("@instructorId", instructorIdTB.Text)});
            if (result > 0)
                MessageBox.Show("ders ekleme işlemi başarılı");
            else
                MessageBox.Show("ders ekleme işlemi başarısız");
            GetSemesterCourses();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(instructorCourseId))
            {
                MessageBox.Show("Lütfen çıkarmak istediğiniz dersi tablodan seçin");
                return;
            }
            var res = MessageBox.Show("Do you want delete?","Confirm", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;
            string command = "Delete SemesterCourse Where SemesterCourseId = @id";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", instructorCourseId) });
            if (result > 0)
                MessageBox.Show("ders çıkarma işlemi başarılı");
            else
                MessageBox.Show("ders çıkarma işlemi başarısız");
            GetSemesterCourses();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentsOfInstructor students = new StudentsOfInstructor(Int32.Parse(instructorIdTB.Text));
            students.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //TODO: Advisor approval

            CourseApproval courseApproval = new CourseApproval(Int32.Parse(instructorIdTB.Text));
            courseApproval.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(instructorCourseId) || !int.TryParse(instructorCourseId, out int semesterCourseId))
            {
                MessageBox.Show("Lütfen not girmek istediğiniz dersi tablodan seçin");
                return;
            }
            StudentsOfCourse studentsOfCourse = new StudentsOfCourse(semesterCourseId);
            studentsOfCourse.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox2.SelectedValue.ToString(), out int semesterId))
                GetSemesterCourses(semesterId);
        }

    }
}
