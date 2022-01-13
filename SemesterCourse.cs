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

    public partial class SemesterCourse : Form
    {
        public SemesterCourse()
        {
            InitializeComponent();
            FillCourses();
            FillInstructors();
            FillSemesters();
            Refresh();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            semesterCourseIdTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[1].Value is DBNull)
                comboBox1.SelectedIndex = -1;
            else
                comboBox1.SelectedValue = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            if (dataGridView1.CurrentRow.Cells[2].Value is DBNull)
                comboBox2.SelectedIndex = -1;
            else
                comboBox2.SelectedValue = Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            if (dataGridView1.CurrentRow.Cells[3].Value is DBNull)
                comboBox3.SelectedIndex = -1;
            else
                comboBox3.SelectedValue = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var semesterId = (int)((DataRowView)comboBox1.SelectedItem).Row[0];
            var courseId = (int)((DataRowView)comboBox2.SelectedItem).Row[0];
            var instructorId = (int)((DataRowView)comboBox3.SelectedItem).Row[0];
            string command = "Insert into SemesterCourse (SemesterId,CourseId,InstructorId) values (@semesterId,@courseId,@instructorId)";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter>
            { new SqlParameter("@semesterId", semesterId), new SqlParameter("@courseId", courseId), new SqlParameter("@instructorId", instructorId), });
            Refresh();
        }


        private void FillSemesters()
        {
            DataTable dataTable = Baglanti.Select("Select * From Semester Where CanAddCourse = 1", null);
            dataTable.Columns.Add("SemesterFull", typeof(string), "Year + ' ' + SemesterType");
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "SemesterFull";
            comboBox1.ValueMember = "SemesterId";
        }

        private void FillCourses()
        {
            DataTable dataTable = Baglanti.Select("Select * From Course", null);
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "CourseId";
        }
        private void FillInstructors()
        {
            DataTable dataTable = Baglanti.Select("Select * From Instructor", null);
            dataTable.Columns.Add("FullName", typeof(string), "Name+ ' ' + Surname");
            comboBox3.DataSource = dataTable;
            comboBox3.DisplayMember = "FullName";
            comboBox3.ValueMember = "InstructorId";
        }

        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select("Select * From SemesterCourse", null);
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var semesterId = (int)((DataRowView)comboBox1.SelectedItem).Row[0];
            var courseId = (int)((DataRowView)comboBox2.SelectedItem).Row[0];
            var instructorId = (int)((DataRowView)comboBox3.SelectedItem).Row[0];
            string command = "Update SemesterCourse Set SemesterId = @semesterId, CourseId= @courseId, InstructorId = @instructorId Where SemesterCourseId = @semesterCourseId";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter>
            { new SqlParameter("@semesterId", semesterId), new SqlParameter("@courseId", courseId), new SqlParameter("@instructorId", instructorId),new SqlParameter("@semesterCourseId", semesterCourseIdTB.Text) });
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string command = "Delete SemesterCourse Where SemesterCourseId = @id";
            var res = MessageBox.Show("Do you want delete?","Confirm", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", semesterCourseIdTB.Text) });
            Refresh();
        }
    }
}
