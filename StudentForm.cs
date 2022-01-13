namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class StudentForm : Form
    {
        string studentCourseId = "";
        public StudentForm(int userId)
        {
            InitializeComponent();
            GetStudent(userId);
            GetRegisteredCourses();
            FillSemesters();
            FillCourses();
        }

        private void GetStudent(int userId)
        {
            DataTable dataTable = Baglanti.Select("Select s.StudentId, s.Name,s.Surname, u.UserName, u.Password, s.UserId, s.Adress, s.Phone, s.BloodType, s.Email, s.BirthDate, s.EntryDate, s.Gender, i.Name Advisor From Student s inner join [User] u on s.UserId = u.UserId left join Instructor i on i.InstructorId = s.AdvisorId Where u.UserId = @userId", new List<SqlParameter>() { new SqlParameter("@userId", userId) });

            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                studentIdTB.Text = row["StudentId"].ToString();
                nameTB.Text = row["Name"].ToString();
                surnameTB.Text = row["Surname"].ToString();
                userNameTB.Text = row["UserName"].ToString();
                //textBox5.Text = row["Password"].ToString();
                userIdTB.Text = row["UserId"].ToString();
                adressTB.Text = row["Adress"].ToString();
                phoneTB.Text = row["Phone"].ToString();
                emailTB.Text = row["Email"].ToString();
                bloodTypeTB.Text = row["BloodType"].ToString();
                genderTB.Text = row["Gender"].ToString();

                birthDatePicker.Text = row["BirthDate"].ToString();
                entryDatePicker.Text = row["EntryDate"].ToString();
                advisorTB.Text = row["Advisor"].ToString();
            }
        }

        private void GetRegisteredCourses()
        {
            DataTable dataTable = Baglanti.Select("Select ssc.RegisterId, s.Year, s.SemesterType, sc.SemesterCourseId , c.Name, ssc.Midterm1, ssc.Midterm2, ssc.FinalGrade, ssc.Average, ssc.SuccessStatus, ssc.Status" +
                " From StudentSemesterCourse ssc inner join SemesterCourse sc on ssc.SemesterCourseId = sc.SemesterCourseId inner join Course c on sc.CourseId = c.CourseId " +
                " inner join Semester s on s.SemesterId = sc.SemesterId Where ssc.StudentId = @userId", new List<SqlParameter>() { new SqlParameter("@userId", studentIdTB.Text) });
            dataGridView1.DataSource = dataTable;
            studentCourseId = string.Empty;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            studentCourseId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void FillSemesters()
        {
            DataTable dataTable = Baglanti.Select("Select * From Semester", null);
            
            dataTable.Columns.Add("SemesterFull", typeof(string), "Year + ' ' + SemesterType");
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "SemesterFull";
            comboBox2.ValueMember = "SemesterId";
        }

        private void FillCourses(int? semesterId = null)
        {
            comboBox1.Text = "Select Course";
            var sql = "Select * From SemesterCourse sc inner join Course c on c.CourseId = sc.CourseId inner join Semester s on s.SemesterId = sc.SemesterId Where s.CanAddCourse=1";
            var list = new List<SqlParameter>();
            if (semesterId.HasValue)
            {
                sql += " and sc.SemesterId = @semesterId";
                list.Add(new SqlParameter("@semesterId", semesterId.Value));
            }
            DataTable dataTable = Baglanti.Select(sql, list);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "SemesterCourseId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTB.Text))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            string command = "Update [User] Set Password= @password Where UserId = @userId";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@password", passwordTB.Text), new SqlParameter("@userId", userIdTB.Text) });
            if (result > 0)
                MessageBox.Show("Password changed.");
            else
                MessageBox.Show("Password didnt changed.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Choose course from list");
                return;
            }
            var semesterCourseId = ((DataRowView)comboBox1.SelectedItem).Row[0].ToString();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value?.ToString() == semesterCourseId)
                {
                    MessageBox.Show("Course is already added.");
                    return;
                }
            }
            
            string command = "Insert into StudentSemesterCourse (SemesterCourseId,StudentId,Midterm1,Midterm2,FinalGrade,Average,SuccessStatus,Status) values (@semesterCourseId, @studentId, @mid1,@mid2,@fin,@avg,@stat,'WAITING')";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> {
                new SqlParameter("@semesterCourseId", semesterCourseId),
                new SqlParameter("@studentId", studentIdTB.Text), 
                new SqlParameter("@mid1", "0"),
                new SqlParameter("@mid2", "0"),
                new SqlParameter("@fin", "0"),
                new SqlParameter("@avg", "0"),
                new SqlParameter("@stat", "")
            });
            if (result > 0)
                MessageBox.Show("Course adding is successful");
            else
                MessageBox.Show("Course adding is not successful");
            GetRegisteredCourses();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentCourseId))
            {
                MessageBox.Show("Select a course from table");
                return;
            }
            var status = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            if (status == "APPROVED")
            {
                MessageBox.Show("You cannot delete approved courses");
                return;
            }
            string command = "Delete StudentSemesterCourse Where RegisterId = @id";
            var res = MessageBox.Show("Do you want delete?","Confirm", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", studentCourseId) });
            if (result > 0)
                MessageBox.Show("Course deletion is successful");
            else
                MessageBox.Show("Course deletion is not successful");
            GetRegisteredCourses();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox2.SelectedValue.ToString(), out int semesterId))
                FillCourses(semesterId);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transcript transcript = new Transcript(this, int.Parse(studentIdTB.Text));
            transcript.Show();
        }
    }
}
