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

    public partial class CourseSearch : Form
    {
        public CourseSearch()
        {
            InitializeComponent();
            FillCourses();
            comboBox1.SelectedIndex = -1;
        }

        private void GetCourseStudents(int courseId, bool rEnrolled=false)
        {
            string command = "Select s.Name, s.Surname, sm.Year,sm.SemesterType From StudentSemesterCourse ssc inner join Student s on s.StudentId = ssc.StudentId inner join SemesterCourse sc on sc.SemesterCourseId = ssc.SemesterCourseId inner join Semester sm on sm.SemesterId = sc.SemesterId Where sc.CourseId = @courseId";

            List<int> reon = new List<int>();
            if(rEnrolled)
            {
                DataTable dataTable1 = Baglanti.Select("Select ssc.StudentId From StudentSemesterCourse ssc inner join SemesterCourse sc on sc.SemesterCourseId = ssc.SemesterCourseId inner join Semester sm on sm.SemesterId = sc.SemesterId Where sc.CourseId = @courseId Group By ssc.StudentId Having Count(ssc.StudentId) > 1", new List<SqlParameter>() { new SqlParameter("@courseId", courseId) });
                foreach (DataRow item in dataTable1.Rows)
                {
                    reon.Add(item.Field<int>(0));
                }
                command += " and s.StudentId in (" + string.Join(",", reon) + ")";
            }
            
            DataTable dataTable = Baglanti.Select(command, new List<SqlParameter>() { new SqlParameter("@courseId", courseId) });
            dataGridView2.DataSource = dataTable;
        }

        private void GetCourseInstructors(int courseId)
        {
            DataTable dataTable = Baglanti.Select("Select i.Name, i.Surname, sm.Year, sm.SemesterType From SemesterCourse sc inner join Instructor i on i.InstructorId = sc.InstructorId inner join Semester sm on sm.SemesterId = sc.SemesterId Where sc.CourseId = @courseId", new List<SqlParameter>() { new SqlParameter("@courseId", courseId) });
            dataGridView1.DataSource = dataTable;
        }

        private void FillCourses()
        {
            DataTable dataTable = Baglanti.Select("Select * From Course", null);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CourseId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                var courseId = (int)((DataRowView)comboBox1.SelectedItem).Row[0];
                GetCourseStudents(courseId);
                GetCourseInstructors(courseId);
                GetMostSuccessful(courseId);
            }
        }

        private void GetMostSuccessful(int courseId)
        {
            string cmd = "Select Top 1 s.* From StudentSemesterCourse ssc inner join SemesterCourse sc on sc.SemesterCourseId = ssc.SemesterCourseId inner join Semester sm on sm.SemesterId = sc.SemesterId inner join Student s on ssc.StudentId = s.StudentId Where sc.CourseId = @courseId Order By Average desc";
            DataTable dataTable = Baglanti.Select(cmd, new List<SqlParameter>() { new SqlParameter("@courseId", courseId) });
            dataGridView3.DataSource = dataTable;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var courseId = (int)((DataRowView)comboBox1.SelectedItem).Row[0];
            GetCourseStudents(courseId, checkBox1.Checked);
        }
    }
}
