namespace FinalEFProject
{
    partial class AdminAddProduct
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
            panel1 = new Panel();
            dgv_displayProd = new DataGridView();
            label9 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btn_del = new Button();
            btn_clear = new Button();
            btn_up = new Button();
            btn_addprod = new Button();
            cb_status = new ComboBox();
            txt_price = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cb_type = new ComboBox();
            txt_productName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txt_stock = new TextBox();
            label1 = new Label();
            txt_productId = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label4 = new Label();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_displayProd).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgv_displayProd);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(22, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 362);
            panel1.TabIndex = 0;
            // 
            // dgv_displayProd
            // 
            dgv_displayProd.AllowUserToAddRows = false;
            dgv_displayProd.AllowUserToDeleteRows = false;
            dgv_displayProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_displayProd.BackgroundColor = Color.White;
            dgv_displayProd.BorderStyle = BorderStyle.None;
            dgv_displayProd.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_displayProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_displayProd.ColumnHeadersHeight = 29;
            dgv_displayProd.EnableHeadersVisualStyles = false;
            dgv_displayProd.Location = new Point(24, 45);
            dgv_displayProd.Name = "dgv_displayProd";
            dgv_displayProd.ReadOnly = true;
            dgv_displayProd.RowHeadersVisible = false;
            dgv_displayProd.RowHeadersWidth = 51;
            dgv_displayProd.Size = new Size(1133, 297);
            dgv_displayProd.TabIndex = 2;
            dgv_displayProd.CellClick += dgv_displayProd_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 15);
            label9.Name = "label9";
            label9.Size = new Size(200, 27);
            label9.TabIndex = 1;
            label9.Text = "Data of Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btn_del);
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(btn_up);
            panel2.Controls.Add(btn_addprod);
            panel2.Controls.Add(cb_status);
            panel2.Controls.Add(txt_price);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cb_type);
            panel2.Controls.Add(txt_productName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_stock);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_productId);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(22, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 265);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 99, 102);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1016, 175);
            button1.Name = "button1";
            button1.Size = new Size(127, 40);
            button1.TabIndex = 23;
            button1.Text = "import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(999, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 125);
            panel3.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 121);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.FromArgb(7, 99, 102);
            btn_del.FlatStyle = FlatStyle.Flat;
            btn_del.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_del.ForeColor = Color.White;
            btn_del.Location = new Point(592, 214);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(139, 48);
            btn_del.TabIndex = 21;
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
            btn_clear.Location = new Point(799, 214);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(141, 48);
            btn_clear.TabIndex = 20;
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
            btn_up.Location = new Point(372, 214);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(141, 48);
            btn_up.TabIndex = 19;
            btn_up.Text = "Update";
            btn_up.UseVisualStyleBackColor = false;
            btn_up.Click += btn_up_Click;
            // 
            // btn_addprod
            // 
            btn_addprod.BackColor = Color.FromArgb(7, 99, 102);
            btn_addprod.FlatStyle = FlatStyle.Flat;
            btn_addprod.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_addprod.ForeColor = Color.White;
            btn_addprod.Location = new Point(150, 214);
            btn_addprod.Name = "btn_addprod";
            btn_addprod.Size = new Size(139, 48);
            btn_addprod.TabIndex = 18;
            btn_addprod.Text = "Add";
            btn_addprod.UseVisualStyleBackColor = false;
            btn_addprod.Click += btn_addprod_Click;
            // 
            // cb_status
            // 
            cb_status.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            cb_status.Location = new Point(632, 147);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(240, 26);
            cb_status.TabIndex = 17;
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_price.Location = new Point(632, 104);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(240, 24);
            txt_price.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label2.Location = new Point(544, 147);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 15;
            label2.Text = "Status : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(525, 104);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 14;
            label3.Text = "Price ($) : ";
            // 
            // cb_type
            // 
            cb_type.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_type.FormattingEnabled = true;
            cb_type.Items.AddRange(new object[] { "Meal", "Drinks" });
            cb_type.Location = new Point(195, 147);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(240, 26);
            cb_type.TabIndex = 13;
            // 
            // txt_productName
            // 
            txt_productName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_productName.Location = new Point(195, 104);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(240, 24);
            txt_productName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label6.Location = new Point(128, 149);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 11;
            label6.Text = "Type : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 104);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 10;
            label7.Text = "Product Name : ";
            // 
            // txt_stock
            // 
            txt_stock.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_stock.Location = new Point(632, 48);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(240, 27);
            txt_stock.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(550, 50);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 8;
            label1.Text = "Stock : ";
            // 
            // txt_productId
            // 
            txt_productId.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_productId.Location = new Point(195, 49);
            txt_productId.Name = "txt_productId";
            txt_productId.Size = new Size(240, 27);
            txt_productId.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 54);
            label8.Name = "label8";
            label8.Size = new Size(120, 21);
            label8.TabIndex = 3;
            label8.Text = "Product ID : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(1184, 9);
            label10.Name = "label10";
            label10.Size = new Size(22, 23);
            label10.TabIndex = 5;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(22, 9);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 6;
            label4.Text = "< Main";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F);
            label5.Location = new Point(123, 9);
            label5.Name = "label5";
            label5.Size = new Size(66, 24);
            label5.TabIndex = 7;
            label5.Text = "< Order";
            label5.Click += label5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 12F);
            label11.Location = new Point(101, 9);
            label11.Name = "label11";
            label11.Size = new Size(14, 24);
            label11.TabIndex = 8;
            label11.Text = "|";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 12F);
            label12.Location = new Point(215, 9);
            label12.Name = "label12";
            label12.Size = new Size(14, 24);
            label12.TabIndex = 9;
            label12.Text = "|";
            // 
            // AdminAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 698);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminAddProduct";
            Load += AdminAddProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_displayProd).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label10;
        private Label label9;
        private TextBox txt_productId;
        private Label label8;
        private ComboBox cb_type;
        private TextBox txt_productName;
        private Label label6;
        private Label label7;
        private TextBox txt_stock;
        private Label label1;
        private ComboBox cb_status;
        private TextBox txt_price;
        private Label label2;
        private Label label3;
        private Button btn_del;
        private Button btn_clear;
        private Button btn_up;
        private Button btn_addprod;
        private Button button1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private DataGridView dgv_displayProd;
        private Label label4;
        private Label label5;
        private Label label11;
        private Label label12;
    }
}