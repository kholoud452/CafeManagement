namespace FinalEFProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            btn_regfromlog = new Button();
            close = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_username = new TextBox();
            txt_LogPassword = new TextBox();
            txt_pass = new Label();
            label6 = new Label();
            check_pass = new CheckBox();
            btn_login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_regfromlog);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 509);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 152);
            label7.Name = "label7";
            label7.Size = new Size(290, 21);
            label7.TabIndex = 12;
            label7.Text = "Cafe Shop Management System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 398);
            label5.Name = "label5";
            label5.Size = new Size(234, 23);
            label5.TabIndex = 11;
            label5.Text = "CREATE AN ACCOUNT";
            // 
            // btn_regfromlog
            // 
            btn_regfromlog.BackColor = Color.FromArgb(7, 99, 102);
            btn_regfromlog.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regfromlog.ForeColor = Color.White;
            btn_regfromlog.Location = new Point(12, 439);
            btn_regfromlog.Name = "btn_regfromlog";
            btn_regfromlog.Size = new Size(296, 41);
            btn_regfromlog.TabIndex = 11;
            btn_regfromlog.Text = "REGISTER";
            btn_regfromlog.UseVisualStyleBackColor = false;
            btn_regfromlog.Click += btn_regfromlog_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(681, 9);
            close.Name = "close";
            close.Size = new Size(33, 34);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 94);
            label2.Name = "label2";
            label2.Size = new Size(99, 27);
            label2.TabIndex = 2;
            label2.Text = "SIGN IN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 168);
            label3.Name = "label3";
            label3.Size = new Size(0, 27);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(349, 168);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 4;
            label4.Text = "Username : ";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(349, 192);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(365, 27);
            txt_username.TabIndex = 5;
            // 
            // txt_LogPassword
            // 
            txt_LogPassword.Location = new Point(349, 265);
            txt_LogPassword.Name = "txt_LogPassword";
            txt_LogPassword.PasswordChar = '*';
            txt_LogPassword.Size = new Size(365, 27);
            txt_LogPassword.TabIndex = 8;
            // 
            // txt_pass
            // 
            txt_pass.AutoSize = true;
            txt_pass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(349, 241);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(114, 21);
            txt_pass.TabIndex = 7;
            txt_pass.Text = "Password : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(349, 241);
            label6.Name = "label6";
            label6.Size = new Size(0, 27);
            label6.TabIndex = 6;
            // 
            // check_pass
            // 
            check_pass.AutoSize = true;
            check_pass.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_pass.Location = new Point(349, 298);
            check_pass.Name = "check_pass";
            check_pass.Size = new Size(161, 24);
            check_pass.TabIndex = 9;
            check_pass.Text = "Show Password";
            check_pass.UseVisualStyleBackColor = true;
            check_pass.CheckedChanged += check_pass_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(7, 99, 102);
            btn_login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(349, 361);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(161, 41);
            btn_login.TabIndex = 10;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(726, 509);
            Controls.Add(btn_login);
            Controls.Add(check_pass);
            Controls.Add(txt_LogPassword);
            Controls.Add(txt_pass);
            Controls.Add(label6);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_username;
        private TextBox txt_LogPassword;
        private Label txt_pass;
        private Label label6;
        private CheckBox check_pass;
        private Button btn_login;
        private Label label5;
        private Button btn_regfromlog;
        private Label label7;
    }
}
