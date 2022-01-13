namespace StudentRegistration
{

    partial class Login
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
            this.girisBtn = new System.Windows.Forms.Button();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userVal = new System.Windows.Forms.Label();
            this.passwordVal = new System.Windows.Forms.Label();
            this.girisVal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(274, 137);
            this.girisBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(88, 42);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.Text = "Login";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(134, 30);
            this.userTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(228, 23);
            this.userTxt.TabIndex = 1;
            this.userTxt.Validating += new System.ComponentModel.CancelEventHandler(this.userTxt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(134, 78);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(228, 23);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // userVal
            // 
            this.userVal.AutoSize = true;
            this.userVal.ForeColor = System.Drawing.Color.Red;
            this.userVal.Location = new System.Drawing.Point(134, 56);
            this.userVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userVal.Name = "userVal";
            this.userVal.Size = new System.Drawing.Size(156, 15);
            this.userVal.TabIndex = 2;
            this.userVal.Text = "User name cannot be empty";
            this.userVal.Visible = false;
            // 
            // passwordVal
            // 
            this.passwordVal.AutoSize = true;
            this.passwordVal.ForeColor = System.Drawing.Color.Red;
            this.passwordVal.Location = new System.Drawing.Point(134, 102);
            this.passwordVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordVal.Name = "passwordVal";
            this.passwordVal.Size = new System.Drawing.Size(150, 15);
            this.passwordVal.TabIndex = 2;
            this.passwordVal.Text = "Password cannot be empty";
            this.passwordVal.Visible = false;
            // 
            // girisVal
            // 
            this.girisVal.AutoSize = true;
            this.girisVal.ForeColor = System.Drawing.Color.Red;
            this.girisVal.Location = new System.Drawing.Point(134, 119);
            this.girisVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.girisVal.Name = "girisVal";
            this.girisVal.Size = new System.Drawing.Size(191, 15);
            this.girisVal.TabIndex = 2;
            this.girisVal.Text = "User name or password is incorrect";
            this.girisVal.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 184);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.girisVal);
            this.Controls.Add(this.passwordVal);
            this.Controls.Add(this.userVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girisBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userVal;
        private System.Windows.Forms.Label passwordVal;
        private System.Windows.Forms.Label girisVal;
        private System.Windows.Forms.Button button1;
    }
}

