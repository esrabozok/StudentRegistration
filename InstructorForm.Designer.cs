namespace StudentRegistration
{

    partial class InstructorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instructorIdTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.bloodTypeTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.userIdTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 239);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(966, 436);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Instructor Id";
            // 
            // instructorIdTB
            // 
            this.instructorIdTB.Location = new System.Drawing.Point(114, 9);
            this.instructorIdTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.instructorIdTB.Name = "instructorIdTB";
            this.instructorIdTB.ReadOnly = true;
            this.instructorIdTB.Size = new System.Drawing.Size(203, 27);
            this.instructorIdTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(862, 683);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Remove Course";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 197);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Course";
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(767, 5);
            this.userNameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.ReadOnly = true;
            this.userNameTB.Size = new System.Drawing.Size(218, 27);
            this.userNameTB.TabIndex = 7;
            // 
            // bloodTypeTB
            // 
            this.bloodTypeTB.Location = new System.Drawing.Point(767, 43);
            this.bloodTypeTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bloodTypeTB.Name = "bloodTypeTB";
            this.bloodTypeTB.ReadOnly = true;
            this.bloodTypeTB.Size = new System.Drawing.Size(219, 27);
            this.bloodTypeTB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "User Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(670, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Birthdate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(670, 127);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Entry Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(672, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Blood Type";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Enabled = false;
            this.birthDatePicker.Location = new System.Drawing.Point(767, 80);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(218, 27);
            this.birthDatePicker.TabIndex = 16;
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.Enabled = false;
            this.entryDatePicker.Location = new System.Drawing.Point(768, 119);
            this.entryDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(218, 27);
            this.entryDatePicker.TabIndex = 16;
            // 
            // userIdTB
            // 
            this.userIdTB.Location = new System.Drawing.Point(453, 9);
            this.userIdTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userIdTB.Name = "userIdTB";
            this.userIdTB.ReadOnly = true;
            this.userIdTB.Size = new System.Drawing.Size(203, 27);
            this.userIdTB.TabIndex = 7;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(453, 48);
            this.surnameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.ReadOnly = true;
            this.surnameTB.Size = new System.Drawing.Size(203, 27);
            this.surnameTB.TabIndex = 7;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(453, 87);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.ReadOnly = true;
            this.phoneTB.Size = new System.Drawing.Size(203, 27);
            this.phoneTB.TabIndex = 7;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(453, 124);
            this.emailTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            this.emailTB.Size = new System.Drawing.Size(203, 27);
            this.emailTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Phone No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Email";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(114, 51);
            this.nameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(203, 27);
            this.nameTB.TabIndex = 7;
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(114, 89);
            this.adressTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.adressTB.Multiline = true;
            this.adressTB.Name = "adressTB";
            this.adressTB.ReadOnly = true;
            this.adressTB.Size = new System.Drawing.Size(203, 100);
            this.adressTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(114, 199);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(203, 27);
            this.passwordTB.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(523, 161);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(345, 28);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(453, 165);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Semester";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 683);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "Get Students List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(277, 683);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 36);
            this.button5.TabIndex = 14;
            this.button5.Text = "Course Approval";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(579, 683);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 36);
            this.button6.TabIndex = 14;
            this.button6.Text = "Enter Note";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 729);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.entryDatePicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructorIdTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bloodTypeTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.userIdTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.nameTB);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InstructorForm";
            this.Text = "Instructor Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox instructorIdTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox bloodTypeTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private System.Windows.Forms.TextBox userIdTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}