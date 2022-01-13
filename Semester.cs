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

    public partial class Semester : Form
    {
        public Semester()
        {
            InitializeComponent();
            Refresh();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            semesterIdTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            yearTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            semesterTypeTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if(!(dataGridView1.CurrentRow.Cells[3].Value is DBNull))
                checkBox1.Checked = (bool)dataGridView1.CurrentRow.Cells[3].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "Insert into Semester (Year,SemesterType,CanAddCourse) values (@year,@type,@canAddCourse)";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@year", yearTB.Text), new SqlParameter("@type", semesterTypeTB.Text), new SqlParameter("@canAddCourse", checkBox1.Checked) });
            Refresh();
        }

        private void Refresh()
        {
            DataTable dataTable = Baglanti.Select("Select * From Semester", null);
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string command = "Update Semester Set Year = @year, SemesterType = @type, CanAddCourse = @canAddCourse Where SemesterId = @id";
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@year", yearTB.Text), new SqlParameter("@id", semesterIdTB.Text), new SqlParameter("@type", semesterTypeTB.Text), new SqlParameter("@canAddCourse", checkBox1.Checked) } );
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string command = "Delete Semester Where SemesterId = @id";
            var res = MessageBox.Show("Do you want delete?","Confirm", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;
            var result = Baglanti.InsertOrUpdate(command, new List<SqlParameter> { new SqlParameter("@id", semesterIdTB.Text) });
            Refresh();
        }
    }
}
