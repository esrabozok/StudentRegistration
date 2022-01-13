namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course ders = new Course();
            var sd = ders.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructor ogretmen = new Instructor();
            ogretmen.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student ogrenci = new Student();
            ogrenci.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Semester semester = new Semester();
            semester.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SemesterCourse semesterCourses = new SemesterCourse();
            semesterCourses.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CourseSearch courseSearch = new CourseSearch();
            courseSearch.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentSemesterCourse studentSemesterCourses = new StudentSemesterCourse();
            studentSemesterCourses.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TestService militaryService = new TestService();
            militaryService.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
