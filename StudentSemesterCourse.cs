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

    public partial class StudentSemesterCourse : Form
    {
        public StudentSemesterCourse(bool disable=false)
        {
            InitializeComponent();
            FillSemesterCourses();
            FillStudents();
            Refresh();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            registerIdTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.SelectedValue = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            comboBox2.SelectedValue = Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            mid1Num.Value = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            mid2Num.Value = Int32.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            finalNum.Value = Int32.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            avgTB.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            statusTB.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var semesterCourseId = (int)((DataRowView)comboBox1.SelectedItem).Row[0];
            var studentId = (int)((DataRowView)comboBox2.SelectedItem).Row[0];
            string command = "Insert into StudentSemesterCourse (SemesterCourseId,StudentId,Midterm1,Midterm2,FinalGrade,Average,SuccessStatus,Status) values (@semesterCourseId,@studentId,@mid1,@mid2,@final,@avg,@status,'WAITING')";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter>
            { new SqlParameter("@semesterCourseId", semesterCourseId), new SqlParameter("@studentId", studentId), new SqlParameter("@mid1", mid1Num.Value),new SqlParameter("@mid2", mid2Num.Value),new SqlParameter("@final", finalNum.Value), new SqlParameter("@avg", avgTB.Text), new SqlParameter("@status", statusTB.Text)});
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var semesterCourseId = (int)((DataRowView)comboBox1.SelectedItem).Row[0];
            var studentId = (int)((DataRowView)comboBox2.SelectedItem).Row[0];
            string command = "Update StudentSemesterCourse Set SemesterCourseId = @semesterCourseId, StudentId= @studentId, Midterm1 = @mid1, Midterm2 = @mid2,FinalGrade = @final, Average=@avg , SuccessStatus=@status Where RegisterId = @id";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter>
            {  new SqlParameter("@semesterCourseId", semesterCourseId), new SqlParameter("@studentId", studentId), new SqlParameter("@mid1", mid1Num.Value),new SqlParameter("@mid2", mid2Num.Value),new SqlParameter("@final", finalNum.Value), new SqlParameter("@avg", avgTB.Text), new SqlParameter("@status", statusTB.Text), new SqlParameter("@id", registerIdTB.Text) });
            Refresh();
        }

        private void FillSemesterCourses()
        {
            DataTable dataTable = Baglanti.Select("Select sc.SemesterCourseId, c.CourseId, c.Name, s.SemesterId, s.Year, s.SemesterType From SemesterCourse sc inner join Course c on sc.CourseId = c.CourseId inner join Semester s on s.SemesterId = sc.SemesterId Where s.CanAddCourse = 1", null);
            dataTable.Columns.Add("SemesterCourseFull", typeof(string), "Name + '('+ Year + ' ' + SemesterType +')'");
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "SemesterCourseFull";
            comboBox1.ValueMember = "SemesterCourseId";
        }

        private void FillStudents()
        {
            DataTable dataTable = Baglanti.Select("Select * From Student Where LeavingDate is null", null);
            dataTable.Columns.Add("FullName", typeof(string), "Name+ ' ' + Surname");
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "FullName";
            comboBox2.ValueMember = "StudentId";
        }
        
        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select("Select * From StudentSemesterCourse", null);
            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string command = "Delete StudentSemesterCourse Where RegisterId = @id";
            var res = MessageBox.Show("Do you want delete?","Confirm", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", registerIdTB.Text) });
            Refresh();
        }
    }
}
