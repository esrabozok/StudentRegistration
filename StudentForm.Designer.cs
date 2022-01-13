namespace StudentRegistration
{

    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentIdTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userIdTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bloodTypeTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.genderTB = new System.Windows.Forms.TextBox();
            this.advisorTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(872, 310);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student Id";
            // 
            // studentIdTB
            // 
            this.studentIdTB.Location = new System.Drawing.Point(100, 7);
            this.studentIdTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentIdTB.Name = "studentIdTB";
            this.studentIdTB.ReadOnly = true;
            this.studentIdTB.Size = new System.Drawing.Size(178, 23);
            this.studentIdTB.TabIndex = 7;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(100, 34);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(178, 23);
            this.nameTB.TabIndex = 7;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(401, 34);
            this.surnameTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.ReadOnly = true;
            this.surnameTB.Size = new System.Drawing.Size(178, 23);
            this.surnameTB.TabIndex = 7;
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(695, 7);
            this.userNameTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.ReadOnly = true;
            this.userNameTB.Size = new System.Drawing.Size(191, 23);
            this.userNameTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(100, 145);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(178, 23);
            this.passwordTB.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(784, 512);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Remove Course";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userIdTB
            // 
            this.userIdTB.Location = new System.Drawing.Point(401, 7);
            this.userIdTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userIdTB.Name = "userIdTB";
            this.userIdTB.ReadOnly = true;
            this.userIdTB.Size = new System.Drawing.Size(178, 23);
            this.userIdTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 169);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Course";
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(100, 63);
            this.adressTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adressTB.Multiline = true;
            this.adressTB.Name = "adressTB";
            this.adressTB.ReadOnly = true;
            this.adressTB.Size = new System.Drawing.Size(178, 74);
            this.adressTB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Adress";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(401, 63);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.ReadOnly = true;
            this.phoneTB.Size = new System.Drawing.Size(178, 23);
            this.phoneTB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Phone No";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(401, 91);
            this.emailTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            this.emailTB.Size = new System.Drawing.Size(178, 23);
            this.emailTB.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(612, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Blood Type";
            // 
            // bloodTypeTB
            // 
            this.bloodTypeTB.Location = new System.Drawing.Point(695, 35);
            this.bloodTypeTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bloodTypeTB.Name = "bloodTypeTB";
            this.bloodTypeTB.ReadOnly = true;
            this.bloodTypeTB.Size = new System.Drawing.Size(192, 23);
            this.bloodTypeTB.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Email";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Enabled = false;
            this.birthDatePicker.Location = new System.Drawing.Point(695, 91);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(191, 23);
            this.birthDatePicker.TabIndex = 16;
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.Enabled = false;
            this.entryDatePicker.Location = new System.Drawing.Point(695, 116);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(191, 23);
            this.entryDatePicker.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(610, 95);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Birthdate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(610, 120);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Entry Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(612, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Gender";
            // 
            // genderTB
            // 
            this.genderTB.Location = new System.Drawing.Point(695, 63);
            this.genderTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.genderTB.Name = "genderTB";
            this.genderTB.ReadOnly = true;
            this.genderTB.Size = new System.Drawing.Size(191, 23);
            this.genderTB.TabIndex = 17;
            // 
            // advisorTB
            // 
            this.advisorTB.Location = new System.Drawing.Point(401, 118);
            this.advisorTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.advisorTB.Name = "advisorTB";
            this.advisorTB.ReadOnly = true;
            this.advisorTB.Size = new System.Drawing.Size(178, 23);
            this.advisorTB.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(318, 121);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Advisor";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All"});
            this.comboBox2.Location = new System.Drawing.Point(488, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 23);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(427, 146);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Semester";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 512);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 27);
            this.button4.TabIndex = 14;
            this.button4.Text = "Transcript";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 547);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.genderTB);
            this.Controls.Add(this.entryDatePicker);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bloodTypeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advisorTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.userIdTB);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.studentIdTB);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentIdTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox userIdTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bloodTypeTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox genderTB;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox advisorTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
    }
}