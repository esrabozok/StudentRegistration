namespace StudentRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            Refresh();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "Insert into Course (Name,Code) values (@courseName,@courseCode)";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@courseName", textBox2.Text), new SqlParameter("@courseCode", textBox3.Text) });
            Refresh();
        }

        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select("Select * From Course", null);
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string command = "Update Course Set Name = @courseName,Code = @courseCode Where CourseId = @id";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@courseName", textBox2.Text), new SqlParameter("@id", textBox1.Text), new SqlParameter("@courseCode", textBox3.Text), });
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string command = "Delete Course Where CourseId = @id";
            var res = MessageBox.Show("Do you want delete?","Confirm", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", textBox1.Text) });
            Refresh();
        }
    }
}
