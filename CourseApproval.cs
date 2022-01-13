namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class CourseApproval : Form
    {
        private readonly int instructorId;

        public CourseApproval(int instructorId)
        {
            this.instructorId = instructorId;
            InitializeComponent();
            Refresh();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select(
                "SELECT ssc.RegisterId, ssc.StudentId, Concat(s.Name,' ',s.Surname) Student, Concat(c.Code, ' ', c.Name) Course, ssc.Status                                     FROM StudentSemesterCourse ssc inner join Student s on ssc.StudentId = s.StudentId inner join SemesterCourse sc on ssc.SemesterCourseId = sc.SemesterCourseId inner join Course c on c.CourseId = sc.CourseId Where s.AdvisorId = @advisorId", new List<SqlParameter> { new SqlParameter("@advisorId", instructorId) });
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "Update StudentSemesterCourse Set Status = @status Where RegisterId = @registerId";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@status", comboBox1.Text), new SqlParameter("@registerId", textBox1.Text) });
            Refresh();
        }

    }
}
