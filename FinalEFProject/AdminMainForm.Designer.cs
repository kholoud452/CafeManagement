namespace FinalEFProject
{
    partial class AdminMainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label9 = new Label();
            panel5 = new Panel();
            dgv_adduser = new DataGridView();
            panel4 = new Panel();
            txt_phone = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btn_del = new Button();
            btn_clear = new Button();
            btn_up = new Button();
            btn_adduser = new Button();
            cb_status = new ComboBox();
            cb_role = new ComboBox();
            txt_password = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_username = new TextBox();
            label8 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            btn_orderPage = new Button();
            btn_logout = new Button();
            btn_addProduct = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            close = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_adduser).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 21);
            label9.Name = "label9";
            label9.Size = new Size(164, 27);
            label9.TabIndex = 0;
            label9.Text = "Data of Users";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dgv_adduser);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(691, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(757, 731);
            panel5.TabIndex = 3;
            // 
            // dgv_adduser
            // 
            dgv_adduser.AllowUserToAddRows = false;
            dgv_adduser.AllowUserToDeleteRows = false;
            dgv_adduser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_adduser.BackgroundColor = Color.White;
            dgv_adduser.BorderStyle = BorderStyle.None;
            dgv_adduser.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_adduser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_adduser.ColumnHeadersHeight = 29;
            dgv_adduser.EnableHeadersVisualStyles = false;
            dgv_adduser.Location = new Point(23, 62);
            dgv_adduser.Name = "dgv_adduser";
            dgv_adduser.ReadOnly = true;
            dgv_adduser.RowHeadersVisible = false;
            dgv_adduser.RowHeadersWidth = 51;
            dgv_adduser.Size = new Size(669, 630);
            dgv_adduser.TabIndex = 1;
            dgv_adduser.CellClick += dgv_adduser_CellClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txt_phone);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(btn_del);
            panel4.Controls.Add(btn_clear);
            panel4.Controls.Add(btn_up);
            panel4.Controls.Add(btn_adduser);
            panel4.Controls.Add(cb_status);
            panel4.Controls.Add(cb_role);
            panel4.Controls.Add(txt_password);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txt_username);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(299, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 731);
            panel4.TabIndex = 2;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_phone.Location = new Point(124, 278);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(240, 27);
            txt_phone.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(41, 280);
            label10.Name = "label10";
            label10.Size = new Size(82, 21);
            label10.TabIndex = 13;
            label10.Text = "Phone : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(92, 91);
            label11.Name = "label11";
            label11.Size = new Size(169, 27);
            label11.TabIndex = 2;
            label11.Text = "Add new User";
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.FromArgb(7, 99, 102);
            btn_del.FlatStyle = FlatStyle.Flat;
            btn_del.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_del.ForeColor = Color.White;
            btn_del.Location = new Point(27, 528);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(139, 48);
            btn_del.TabIndex = 12;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += btn_del_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(7, 99, 102);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(197, 528);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(141, 48);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_up
            // 
            btn_up.BackColor = Color.FromArgb(7, 99, 102);
            btn_up.FlatStyle = FlatStyle.Flat;
            btn_up.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_up.ForeColor = Color.White;
            btn_up.Location = new Point(197, 431);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(141, 48);
            btn_up.TabIndex = 10;
            btn_up.Text = "Update";
            btn_up.UseVisualStyleBackColor = false;
            btn_up.Click += btn_up_Click;
            // 
            // btn_adduser
            // 
            btn_adduser.BackColor = Color.FromArgb(7, 99, 102);
            btn_adduser.FlatStyle = FlatStyle.Flat;
            btn_adduser.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_adduser.ForeColor = Color.White;
            btn_adduser.Location = new Point(27, 431);
            btn_adduser.Name = "btn_adduser";
            btn_adduser.Size = new Size(139, 48);
            btn_adduser.TabIndex = 9;
            btn_adduser.Text = "Add";
            btn_adduser.UseVisualStyleBackColor = false;
            btn_adduser.Click += btn_adduser_Click;
            // 
            // cb_status
            // 
            cb_status.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Active", "Inactive", "Approval" });
            cb_status.Location = new Point(124, 369);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(240, 26);
            cb_status.TabIndex = 8;
            // 
            // cb_role
            // 
            cb_role.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "Employee", "User" });
            cb_role.Location = new Point(124, 321);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(240, 26);
            cb_role.TabIndex = 7;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(124, 238);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(240, 24);
            txt_password.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label5.Location = new Point(41, 369);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 5;
            label5.Text = "Status : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label6.Location = new Point(57, 323);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 4;
            label6.Text = "Role : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 236);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 3;
            label7.Text = "Password : ";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(124, 194);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(240, 27);
            txt_username.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 196);
            label8.Name = "label8";
            label8.Size = new Size(118, 21);
            label8.TabIndex = 1;
            label8.Text = "Username : ";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1460, 749);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 99, 102);
            panel2.Controls.Add(btn_orderPage);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_addProduct);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 749);
            panel2.TabIndex = 5;
            // 
            // btn_orderPage
            // 
            btn_orderPage.FlatStyle = FlatStyle.Flat;
            btn_orderPage.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_orderPage.ForeColor = Color.White;
            btn_orderPage.Location = new Point(12, 474);
            btn_orderPage.Name = "btn_orderPage";
            btn_orderPage.Size = new Size(268, 47);
            btn_orderPage.TabIndex = 11;
            btn_orderPage.Text = "Order Page";
            btn_orderPage.UseVisualStyleBackColor = true;
            btn_orderPage.Click += btn_orderPage_Click;
            // 
            // btn_logout
            // 
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(12, 686);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(268, 47);
            btn_logout.TabIndex = 10;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click_1;
            // 
            // btn_addProduct
            // 
            btn_addProduct.FlatStyle = FlatStyle.Flat;
            btn_addProduct.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addProduct.ForeColor = Color.White;
            btn_addProduct.Location = new Point(12, 412);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(268, 47);
            btn_addProduct.TabIndex = 9;
            btn_addProduct.Text = "Add Product";
            btn_addProduct.UseVisualStyleBackColor = true;
            btn_addProduct.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 359);
            button2.Name = "button2";
            button2.Size = new Size(268, 47);
            button2.TabIndex = 7;
            button2.Text = "Customers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 306);
            button1.Name = "button1";
            button1.Size = new Size(268, 47);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(144, 182);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 6;
            label4.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 180);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "Username : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 102);
            label2.Name = "label2";
            label2.Size = new Size(174, 27);
            label2.TabIndex = 4;
            label2.Text = "Admin's Portal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1460, 45);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(290, 21);
            label1.TabIndex = 3;
            label1.Text = "Cafe Shop Management System";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(1422, 8);
            close.Name = "close";
            close.Size = new Size(26, 27);
            close.TabIndex = 2;
            close.Text = "X";
            close.Click += close_Click_1;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 794);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            Load += AdminMainForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_adduser).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label9;
        private Panel panel5;
        private DataGridView dgv_adduser;
        private Panel panel4;
        private Button btn_del;
        private Button btn_clear;
        private Button btn_up;
        private Button btn_adduser;
        private ComboBox cb_status;
        private ComboBox cb_role;
        private TextBox txt_password;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_username;
        private Label label8;
        private Panel panel3;
        private Panel panel1;
        private Label label1;
        private Label close;
        private Label label11;
        private Panel panel2;
        private Button btn_logout;
        private Button btn_addProduct;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_orderPage;
        private TextBox txt_phone;
        private Label label10;
    }
}