namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class Transcript : Form
    {
        Form parent;
        public Transcript(Form p, int studentId)
        {
            parent = p;
            InitializeComponent();
            GetStudent(studentId);
            GetRegisteredCourses();
        }

        private void GetStudent(int studentId)
        {
            DataTable dataTable = Baglanti.Select("Select s.StudentId, s.Name,s.Surname, u.UserName, u.Password, s.UserId, s.Adress, s.Phone, s.BloodType, s.Email, s.BirthDate, s.EntryDate, s.Gender, i.Name Advisor From Student s inner join [User] u on s.UserId = u.UserId left join Instructor i on i.InstructorId = s.AdvisorId Where s.StudentId = @studentId", new List<SqlParameter>() { new SqlParameter("@studentId", studentId) });

            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                studentIdTB.Text = row["StudentId"].ToString();
                nameTB.Text = row["Name"].ToString();
                surnameTB.Text = row["Surname"].ToString();
            }
        }

        private void GetRegisteredCourses()
        {
            DataTable dataTable = Baglanti.Select("Select ssc.RegisterId, s.Year, s.SemesterType, sc.SemesterCourseId , c.Name, ssc.Midterm1, ssc.Midterm2, ssc.FinalGrade, ssc.Average, ssc.SuccessStatus, ssc.Status" +
                " From StudentSemesterCourse ssc inner join SemesterCourse sc on ssc.SemesterCourseId = sc.SemesterCourseId inner join Course c on sc.CourseId = c.CourseId " +
                " inner join Semester s on s.SemesterId = sc.SemesterId Where ssc.StudentId = @userId", new List<SqlParameter>() { new SqlParameter("@userId", studentIdTB.Text) });
            dataGridView1.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
