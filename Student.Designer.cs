namespace StudentRegistration
{
    partial class Student
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.studentIdTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.userIdTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bloodTypeTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.genderTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1017, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1017, 56);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1017, 96);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 225);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 376);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Students";
            // 
            // studentIdTB
            // 
            this.studentIdTB.Location = new System.Drawing.Point(110, 16);
            this.studentIdTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.studentIdTB.Name = "studentIdTB";
            this.studentIdTB.ReadOnly = true;
            this.studentIdTB.Size = new System.Drawing.Size(203, 27);
            this.studentIdTB.TabIndex = 7;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(110, 52);
            this.nameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(203, 27);
            this.nameTB.TabIndex = 7;
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(110, 91);
            this.adressTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.adressTB.Multiline = true;
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(203, 67);
            this.adressTB.TabIndex = 7;
            // 
            // userIdTB
            // 
            this.userIdTB.Location = new System.Drawing.Point(454, 16);
            this.userIdTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userIdTB.Name = "userIdTB";
            this.userIdTB.ReadOnly = true;
            this.userIdTB.Size = new System.Drawing.Size(203, 27);
            this.userIdTB.TabIndex = 7;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(454, 52);
            this.surnameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(203, 27);
            this.surnameTB.TabIndex = 7;
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(790, 16);
            this.userNameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(218, 27);
            this.userNameTB.TabIndex = 7;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(454, 91);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(203, 27);
            this.phoneTB.TabIndex = 7;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(454, 128);
            this.emailTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(203, 27);
            this.emailTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student Id";
            // 
            // bloodTypeTB
            // 
            this.bloodTypeTB.Location = new System.Drawing.Point(454, 165);
            this.bloodTypeTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bloodTypeTB.Name = "bloodTypeTB";
            this.bloodTypeTB.Size = new System.Drawing.Size(203, 27);
            this.bloodTypeTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(694, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Birthdate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(694, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Entry Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Blood Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(110, 165);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(203, 27);
            this.passwordTB.TabIndex = 13;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(791, 89);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(218, 27);
            this.birthDatePicker.TabIndex = 16;
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.Location = new System.Drawing.Point(790, 125);
            this.entryDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(220, 27);
            this.entryDatePicker.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(694, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Gender(Male/Female)";
            // 
            // genderTB
            // 
            this.genderTB.Location = new System.Drawing.Point(858, 52);
            this.genderTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.genderTB.Name = "genderTB";
            this.genderTB.Size = new System.Drawing.Size(151, 27);
            this.genderTB.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(694, 169);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Advisor";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(790, 165);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(220, 28);
            this.comboBox3.TabIndex = 19;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 617);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.genderTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.entryDatePicker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userIdTB);
            this.Controls.Add(this.studentIdTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bloodTypeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentIdTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.TextBox userIdTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bloodTypeTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox genderTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}