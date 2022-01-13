namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class StudentsOfCourse : Form
    {
        private readonly int semesterCourseId;

        public StudentsOfCourse(int semesterCourseId)
        {
            this.semesterCourseId = semesterCourseId;
            InitializeComponent();
            Refresh();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select(
                "SELECT ssc.RegisterId, ssc.StudentId, Concat(s.Name,' ',s.Surname) Student, Concat(c.Code, ' ', c.Name) Course, ssc.SuccessStatus                                     FROM StudentSemesterCourse ssc inner join Student s on ssc.StudentId = s.StudentId inner join SemesterCourse sc on ssc.SemesterCourseId = sc.SemesterCourseId inner join Course c on c.CourseId = sc.CourseId Where sc.SemesterCourseId = @semesterCourseId", new List<SqlParameter> { new SqlParameter("@semesterCourseId", semesterCourseId) });
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mid1 = (double)mid1Num.Value;
            double final = (double)finalNum.Value;
            var average = mid1 * 0.6 + final* 0.4;
            var status = average < 50 ? "FAIL" : "PASS";
            string command = "Update StudentSemesterCourse Set Midterm1 = @midterm1, Midterm2 = @midterm2, Average = @average, SuccessStatus = @status Where RegisterId = @registerId";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@registerId", textBox1.Text), new SqlParameter("@midterm1", mid1Num.Value), new SqlParameter("@midterm2", mid2Num.Value), new SqlParameter("@average", average), new SqlParameter("@status", status) });
            Refresh();
        }

    }
}
