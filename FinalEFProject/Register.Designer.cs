namespace FinalEFProject
{
    partial class Register
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
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            btn_logfromreg = new Button();
            btn_register = new Button();
            check_pass = new CheckBox();
            txt_password = new TextBox();
            txt_pass = new Label();
            label6 = new Label();
            txt_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            close = new Label();
            txt_conPass = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txt_phoneNumber = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_logfromreg);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 509);
            panel1.TabIndex = 11;
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
            label5.Location = new Point(12, 383);
            label5.Name = "label5";
            label5.Size = new Size(308, 23);
            label5.TabIndex = 11;
            label5.Text = "ALREADY HAVE AN ACCOUNT";
            // 
            // btn_logfromreg
            // 
            btn_logfromreg.BackColor = Color.FromArgb(7, 99, 102);
            btn_logfromreg.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logfromreg.ForeColor = Color.White;
            btn_logfromreg.Location = new Point(12, 418);
            btn_logfromreg.Name = "btn_logfromreg";
            btn_logfromreg.Size = new Size(296, 41);
            btn_logfromreg.TabIndex = 11;
            btn_logfromreg.Text = "LOGIN HERE";
            btn_logfromreg.UseVisualStyleBackColor = false;
            btn_logfromreg.Click += btn_logfromreg_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(7, 99, 102);
            btn_register.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(427, 418);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(161, 41);
            btn_register.TabIndex = 21;
            btn_register.Text = "SIGNUP";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // check_pass
            // 
            check_pass.AutoSize = true;
            check_pass.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_pass.Location = new Point(331, 381);
            check_pass.Name = "check_pass";
            check_pass.Size = new Size(161, 24);
            check_pass.TabIndex = 20;
            check_pass.Text = "Show Password";
            check_pass.UseVisualStyleBackColor = true;
            check_pass.CheckedChanged += check_pass_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(331, 273);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(365, 27);
            txt_password.TabIndex = 19;
            // 
            // txt_pass
            // 
            txt_pass.AutoSize = true;
            txt_pass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(331, 249);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(114, 21);
            txt_pass.TabIndex = 18;
            txt_pass.Text = "Password : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(331, 214);
            label6.Name = "label6";
            label6.Size = new Size(0, 27);
            label6.TabIndex = 17;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(331, 139);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(365, 27);
            txt_username.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 115);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 15;
            label4.Text = "Username : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 115);
            label3.Name = "label3";
            label3.Size = new Size(0, 27);
            label3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 57);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 13;
            label2.Text = "REGISTER";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(680, 9);
            close.Name = "close";
            close.Size = new Size(33, 34);
            close.TabIndex = 12;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // txt_conPass
            // 
            txt_conPass.Location = new Point(331, 348);
            txt_conPass.Name = "txt_conPass";
            txt_conPass.PasswordChar = '*';
            txt_conPass.Size = new Size(365, 27);
            txt_conPass.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(331, 324);
            label8.Name = "label8";
            label8.Size = new Size(189, 21);
            label8.TabIndex = 23;
            label8.Text = "Confirm Password : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(331, 301);
            label9.Name = "label9";
            label9.Size = new Size(0, 27);
            label9.TabIndex = 22;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Location = new Point(331, 214);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(365, 27);
            txt_phoneNumber.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 190);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 25;
            label1.Text = "Phone Number : ";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(726, 509);
            Controls.Add(txt_phoneNumber);
            Controls.Add(label1);
            Controls.Add(txt_conPass);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(btn_register);
            Controls.Add(check_pass);
            Controls.Add(txt_password);
            Controls.Add(txt_pass);
            Controls.Add(label6);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label5;
        private Button btn_logfromreg;
        private Button btn_register;
        private CheckBox check_pass;
        private TextBox txt_password;
        private Label txt_pass;
        private Label label6;
        private TextBox txt_username;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label close;
        private TextBox txt_conPass;
        private Label label8;
        private Label label9;
        private TextBox txt_phoneNumber;
        private Label label1;
    }
}