namespace FinalEFProject
{
    partial class EmployeeMainForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_logout = new Button();
            addProduct_btn = new Button();
            customers_btn = new Button();
            label_userPortal = new Label();
            username = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            label_totalPriceValue = new Label();
            label_totalPrice = new Label();
            label18 = new Label();
            txt_OrderProdID = new TextBox();
            label16 = new Label();
            label15 = new Label();
            nud_orderQuantitytoPay = new NumericUpDown();
            btn_delOrder = new Button();
            dgv_displayOrderData = new DataGridView();
            label_change = new Label();
            btn_orderPay = new Button();
            label14 = new Label();
            txt_amount = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label_orderPrice = new Label();
            panel5 = new Panel();
            btn_CheckCustomerExist = new Button();
            txt_cusPhone = new TextBox();
            label10 = new Label();
            label_priceMenu = new Label();
            label_menuProdName = new Label();
            cb_empProdID = new ComboBox();
            label12 = new Label();
            btn_menuAdd = new Button();
            btn_menuClear = new Button();
            label8 = new Label();
            nud_quantity = new NumericUpDown();
            label7 = new Label();
            cb_empType = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            dgv_orderTable = new DataGridView();
            dataGridView1 = new DataGridView();
            dgv_empMenu = new DataGridView();
            label9 = new Label();
            btn_backToAdmin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_orderQuantitytoPay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_displayOrderData).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_quantity).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_orderTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_empMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(btn_backToAdmin);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(addProduct_btn);
            panel1.Controls.Add(customers_btn);
            panel1.Controls.Add(label_userPortal);
            panel1.Controls.Add(username);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 745);
            panel1.TabIndex = 13;
            // 
            // btn_logout
            // 
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(13, 646);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(268, 47);
            btn_logout.TabIndex = 17;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click_1;
            // 
            // addProduct_btn
            // 
            addProduct_btn.FlatStyle = FlatStyle.Flat;
            addProduct_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProduct_btn.ForeColor = Color.White;
            addProduct_btn.Location = new Point(13, 372);
            addProduct_btn.Name = "addProduct_btn";
            addProduct_btn.Size = new Size(268, 47);
            addProduct_btn.TabIndex = 16;
            addProduct_btn.Text = "Add Product";
            addProduct_btn.UseVisualStyleBackColor = true;
            addProduct_btn.Click += addProduct_btn_Click_1;
            // 
            // customers_btn
            // 
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(13, 319);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(268, 47);
            customers_btn.TabIndex = 15;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = true;
            customers_btn.Click += customers_btn_Click;
            // 
            // label_userPortal
            // 
            label_userPortal.AutoSize = true;
            label_userPortal.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_userPortal.ForeColor = Color.White;
            label_userPortal.Location = new Point(145, 142);
            label_userPortal.Name = "label_userPortal";
            label_userPortal.Size = new Size(79, 17);
            label_userPortal.TabIndex = 14;
            label_userPortal.Text = "Employee";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.White;
            username.Location = new Point(33, 140);
            username.Name = "username";
            username.Size = new Size(106, 20);
            username.TabIndex = 13;
            username.Text = "Username : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 75);
            label2.Name = "label2";
            label2.Size = new Size(212, 27);
            label2.TabIndex = 12;
            label2.Text = "Employee's Portal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1500, 45);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1466, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 23);
            label1.TabIndex = 4;
            label1.Text = "X";
            label1.Click += label1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(290, 21);
            label5.TabIndex = 3;
            label5.Text = "Cafe Shop Management System";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1500, 790);
            panel3.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label_totalPriceValue);
            panel6.Controls.Add(label_totalPrice);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(txt_OrderProdID);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(nud_orderQuantitytoPay);
            panel6.Controls.Add(btn_delOrder);
            panel6.Controls.Add(dgv_displayOrderData);
            panel6.Controls.Add(label_change);
            panel6.Controls.Add(btn_orderPay);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(txt_amount);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label_orderPrice);
            panel6.Location = new Point(986, 51);
            panel6.Name = "panel6";
            panel6.Size = new Size(511, 727);
            panel6.TabIndex = 1;
            // 
            // label_totalPriceValue
            // 
            label_totalPriceValue.AutoSize = true;
            label_totalPriceValue.Location = new Point(125, 517);
            label_totalPriceValue.Name = "label_totalPriceValue";
            label_totalPriceValue.Size = new Size(0, 20);
            label_totalPriceValue.TabIndex = 36;
            // 
            // label_totalPrice
            // 
            label_totalPrice.AutoSize = true;
            label_totalPrice.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label_totalPrice.Location = new Point(16, 517);
            label_totalPrice.Name = "label_totalPrice";
            label_totalPrice.Size = new Size(112, 21);
            label_totalPrice.TabIndex = 35;
            label_totalPrice.Text = "T Price($) : ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label18.Location = new Point(135, 517);
            label18.Name = "label18";
            label18.Size = new Size(0, 21);
            label18.TabIndex = 34;
            // 
            // txt_OrderProdID
            // 
            txt_OrderProdID.Location = new Point(130, 410);
            txt_OrderProdID.Name = "txt_OrderProdID";
            txt_OrderProdID.Size = new Size(240, 27);
            txt_OrderProdID.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label16.Location = new Point(28, 416);
            label16.Name = "label16";
            label16.Size = new Size(96, 21);
            label16.TabIndex = 30;
            label16.Text = "Prod_ID : ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label15.Location = new Point(24, 456);
            label15.Name = "label15";
            label15.Size = new Size(100, 21);
            label15.TabIndex = 29;
            label15.Text = "Quantity : ";
            // 
            // nud_orderQuantitytoPay
            // 
            nud_orderQuantitytoPay.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_orderQuantitytoPay.Location = new Point(130, 450);
            nud_orderQuantitytoPay.Name = "nud_orderQuantitytoPay";
            nud_orderQuantitytoPay.Size = new Size(240, 34);
            nud_orderQuantitytoPay.TabIndex = 28;
            // 
            // btn_delOrder
            // 
            btn_delOrder.BackColor = Color.FromArgb(7, 99, 102);
            btn_delOrder.FlatStyle = FlatStyle.Flat;
            btn_delOrder.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_delOrder.ForeColor = Color.White;
            btn_delOrder.Location = new Point(16, 613);
            btn_delOrder.Name = "btn_delOrder";
            btn_delOrder.Size = new Size(485, 48);
            btn_delOrder.TabIndex = 27;
            btn_delOrder.Text = "Delete ";
            btn_delOrder.UseVisualStyleBackColor = false;
            btn_delOrder.Click += btn_delOrder_Click;
            // 
            // dgv_displayOrderData
            // 
            dgv_displayOrderData.AllowUserToAddRows = false;
            dgv_displayOrderData.AllowUserToDeleteRows = false;
            dgv_displayOrderData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_displayOrderData.BackgroundColor = Color.White;
            dgv_displayOrderData.BorderStyle = BorderStyle.None;
            dgv_displayOrderData.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_displayOrderData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_displayOrderData.ColumnHeadersHeight = 29;
            dgv_displayOrderData.EnableHeadersVisualStyles = false;
            dgv_displayOrderData.Location = new Point(3, 16);
            dgv_displayOrderData.Name = "dgv_displayOrderData";
            dgv_displayOrderData.ReadOnly = true;
            dgv_displayOrderData.RowHeadersVisible = false;
            dgv_displayOrderData.RowHeadersWidth = 51;
            dgv_displayOrderData.Size = new Size(505, 356);
            dgv_displayOrderData.TabIndex = 26;
            dgv_displayOrderData.CellClick += dgv_displayOrderData_CellClick;
            // 
            // label_change
            // 
            label_change.AutoSize = true;
            label_change.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label_change.Location = new Point(157, 581);
            label_change.Name = "label_change";
            label_change.Size = new Size(0, 21);
            label_change.TabIndex = 25;
            // 
            // btn_orderPay
            // 
            btn_orderPay.BackColor = Color.FromArgb(7, 99, 102);
            btn_orderPay.FlatStyle = FlatStyle.Flat;
            btn_orderPay.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_orderPay.ForeColor = Color.White;
            btn_orderPay.Location = new Point(17, 663);
            btn_orderPay.Name = "btn_orderPay";
            btn_orderPay.Size = new Size(485, 48);
            btn_orderPay.TabIndex = 23;
            btn_orderPay.Text = "PAY";
            btn_orderPay.UseVisualStyleBackColor = false;
            btn_orderPay.Click += btn_orderPay_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(23, 580);
            label14.Name = "label14";
            label14.Size = new Size(117, 21);
            label14.TabIndex = 21;
            label14.Text = "Change($) : ";
            // 
            // txt_amount
            // 
            txt_amount.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_amount.Location = new Point(137, 550);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(233, 27);
            txt_amount.TabIndex = 20;
            txt_amount.TextChanged += txt_amount_TextChanged;
            txt_amount.KeyDown += txt_amount_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(23, 552);
            label13.Name = "label13";
            label13.Size = new Size(117, 21);
            label13.TabIndex = 19;
            label13.Text = "Amount($) : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label11.Location = new Point(28, 487);
            label11.Name = "label11";
            label11.Size = new Size(101, 21);
            label11.TabIndex = 18;
            label11.Text = "Price ($) : ";
            // 
            // label_orderPrice
            // 
            label_orderPrice.AutoSize = true;
            label_orderPrice.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label_orderPrice.Location = new Point(135, 487);
            label_orderPrice.Name = "label_orderPrice";
            label_orderPrice.Size = new Size(0, 21);
            label_orderPrice.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btn_CheckCustomerExist);
            panel5.Controls.Add(txt_cusPhone);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label_priceMenu);
            panel5.Controls.Add(label_menuProdName);
            panel5.Controls.Add(cb_empProdID);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(btn_menuAdd);
            panel5.Controls.Add(btn_menuClear);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(nud_quantity);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(cb_empType);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(300, 446);
            panel5.Name = "panel5";
            panel5.Size = new Size(680, 332);
            panel5.TabIndex = 1;
            // 
            // btn_CheckCustomerExist
            // 
            btn_CheckCustomerExist.BackColor = Color.FromArgb(7, 99, 102);
            btn_CheckCustomerExist.FlatStyle = FlatStyle.Flat;
            btn_CheckCustomerExist.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_CheckCustomerExist.ForeColor = Color.White;
            btn_CheckCustomerExist.Location = new Point(439, 25);
            btn_CheckCustomerExist.Name = "btn_CheckCustomerExist";
            btn_CheckCustomerExist.Size = new Size(147, 33);
            btn_CheckCustomerExist.TabIndex = 33;
            btn_CheckCustomerExist.Text = "Check Exist";
            btn_CheckCustomerExist.UseVisualStyleBackColor = false;
            btn_CheckCustomerExist.Click += btn_CheckCustomerExist_Click;
            // 
            // txt_cusPhone
            // 
            txt_cusPhone.Location = new Point(193, 29);
            txt_cusPhone.Name = "txt_cusPhone";
            txt_cusPhone.Size = new Size(240, 27);
            txt_cusPhone.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label10.Location = new Point(13, 24);
            label10.Name = "label10";
            label10.Size = new Size(173, 21);
            label10.TabIndex = 31;
            label10.Text = "Customer Phone : ";
            // 
            // label_priceMenu
            // 
            label_priceMenu.AutoSize = true;
            label_priceMenu.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label_priceMenu.Location = new Point(167, 295);
            label_priceMenu.Name = "label_priceMenu";
            label_priceMenu.Size = new Size(0, 21);
            label_priceMenu.TabIndex = 30;
            // 
            // label_menuProdName
            // 
            label_menuProdName.AutoSize = true;
            label_menuProdName.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label_menuProdName.Location = new Point(172, 246);
            label_menuProdName.Name = "label_menuProdName";
            label_menuProdName.Size = new Size(0, 21);
            label_menuProdName.TabIndex = 27;
            // 
            // cb_empProdID
            // 
            cb_empProdID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_empProdID.FormattingEnabled = true;
            cb_empProdID.Location = new Point(193, 117);
            cb_empProdID.Name = "cb_empProdID";
            cb_empProdID.Size = new Size(240, 26);
            cb_empProdID.TabIndex = 25;
            cb_empProdID.SelectedIndexChanged += cb_empProdID_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label12.Location = new Point(81, 289);
            label12.Name = "label12";
            label12.Size = new Size(101, 21);
            label12.TabIndex = 24;
            label12.Text = "Price ($) : ";
            // 
            // btn_menuAdd
            // 
            btn_menuAdd.BackColor = Color.FromArgb(7, 99, 102);
            btn_menuAdd.FlatStyle = FlatStyle.Flat;
            btn_menuAdd.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_menuAdd.ForeColor = Color.White;
            btn_menuAdd.Location = new Point(485, 117);
            btn_menuAdd.Name = "btn_menuAdd";
            btn_menuAdd.Size = new Size(174, 48);
            btn_menuAdd.TabIndex = 22;
            btn_menuAdd.Text = "ADD";
            btn_menuAdd.UseVisualStyleBackColor = false;
            btn_menuAdd.Click += btn_menuAdd_Click;
            // 
            // btn_menuClear
            // 
            btn_menuClear.BackColor = Color.FromArgb(7, 99, 102);
            btn_menuClear.FlatStyle = FlatStyle.Flat;
            btn_menuClear.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_menuClear.ForeColor = Color.White;
            btn_menuClear.Location = new Point(485, 194);
            btn_menuClear.Name = "btn_menuClear";
            btn_menuClear.Size = new Size(174, 48);
            btn_menuClear.TabIndex = 20;
            btn_menuClear.Text = "CLEAR";
            btn_menuClear.UseVisualStyleBackColor = false;
            btn_menuClear.Click += btn_menuClear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label8.Location = new Point(82, 178);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 16;
            label8.Text = "Quantity : ";
            // 
            // nud_quantity
            // 
            nud_quantity.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_quantity.Location = new Point(188, 172);
            nud_quantity.Name = "nud_quantity";
            nud_quantity.Size = new Size(245, 34);
            nud_quantity.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label7.Location = new Point(33, 243);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 13;
            label7.Text = "Product Name : ";
            // 
            // cb_empType
            // 
            cb_empType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_empType.FormattingEnabled = true;
            cb_empType.Items.AddRange(new object[] { "Meals", "Drinks" });
            cb_empType.Location = new Point(193, 72);
            cb_empType.Name = "cb_empType";
            cb_empType.Size = new Size(240, 26);
            cb_empType.TabIndex = 12;
            cb_empType.SelectedIndexChanged += cb_empType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label6.Location = new Point(113, 70);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 11;
            label6.Text = "Type : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label3.Location = new Point(67, 119);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 9;
            label3.Text = "ProductID : ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dgv_orderTable);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(dgv_empMenu);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(300, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(680, 389);
            panel4.TabIndex = 0;
            // 
            // dgv_orderTable
            // 
            dgv_orderTable.AllowUserToAddRows = false;
            dgv_orderTable.AllowUserToDeleteRows = false;
            dgv_orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_orderTable.BackgroundColor = Color.White;
            dgv_orderTable.BorderStyle = BorderStyle.None;
            dgv_orderTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_orderTable.ColumnHeadersHeight = 29;
            dgv_orderTable.EnableHeadersVisualStyles = false;
            dgv_orderTable.Location = new Point(867, 16);
            dgv_orderTable.Name = "dgv_orderTable";
            dgv_orderTable.ReadOnly = true;
            dgv_orderTable.RowHeadersVisible = false;
            dgv_orderTable.RowHeadersWidth = 51;
            dgv_orderTable.Size = new Size(350, 373);
            dgv_orderTable.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(867, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(306, 373);
            dataGridView1.TabIndex = 4;
            // 
            // dgv_empMenu
            // 
            dgv_empMenu.AllowUserToAddRows = false;
            dgv_empMenu.AllowUserToDeleteRows = false;
            dgv_empMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empMenu.BackgroundColor = Color.White;
            dgv_empMenu.BorderStyle = BorderStyle.None;
            dgv_empMenu.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_empMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_empMenu.ColumnHeadersHeight = 29;
            dgv_empMenu.EnableHeadersVisualStyles = false;
            dgv_empMenu.Location = new Point(13, 57);
            dgv_empMenu.Name = "dgv_empMenu";
            dgv_empMenu.ReadOnly = true;
            dgv_empMenu.RowHeadersVisible = false;
            dgv_empMenu.RowHeadersWidth = 51;
            dgv_empMenu.Size = new Size(646, 314);
            dgv_empMenu.TabIndex = 3;
            dgv_empMenu.CellContentClick += dgv_empMenu_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 16);
            label9.Name = "label9";
            label9.Size = new Size(73, 27);
            label9.TabIndex = 2;
            label9.Text = "Menu";
            // 
            // btn_backToAdmin
            // 
            btn_backToAdmin.BackColor = Color.FromArgb(7, 99, 102);
            btn_backToAdmin.FlatStyle = FlatStyle.Flat;
            btn_backToAdmin.Font = new Font("Arial Rounded MT Bold", 10.8F);
            btn_backToAdmin.ForeColor = Color.White;
            btn_backToAdmin.Location = new Point(13, 425);
            btn_backToAdmin.Name = "btn_backToAdmin";
            btn_backToAdmin.Size = new Size(268, 48);
            btn_backToAdmin.TabIndex = 23;
            btn_backToAdmin.Text = "Back";
            btn_backToAdmin.UseVisualStyleBackColor = false;
            btn_backToAdmin.Click += btn_backToAdmin_Click;
            // 
            // EmployeeMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeMainForm";
            Load += EmployeeMainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_orderQuantitytoPay).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_displayOrderData).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_quantity).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_orderTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_empMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_logout;
        private Button addProduct_btn;
        private Button customers_btn;
        private Label label_userPortal;
        private Label username;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Panel panel3;
        private Panel panel6;
        private Label label_change;
        private Button btn_orderPay;
        private Label label14;
        private TextBox txt_amount;
        private Label label13;
        private Label label11;
        private Label label_orderPrice;
        private Panel panel5;
        private Label label12;
        private Button btn_menuAdd;
        private Button btn_menuClear;
        private Label label8;
        private NumericUpDown nud_quantity;
        private Label label7;
        private ComboBox cb_empType;
        private Label label6;
        private Label label3;
        private Panel panel4;
        private DataGridView dgv_orderTable;
        private DataGridView dataGridView1;
        private DataGridView dgv_empMenu;
        private Label label9;
        private ComboBox cb_empProdID;
        private DataGridView dgv_displayOrderData;
        private Label label_menuProdName;
        private Label label_priceMenu;
        private TextBox txt_cusPhone;
        private Label label10;
        private Button btn_CheckCustomerExist;
        private Button btn_delOrder;
        private Label label16;
        private Label label15;
        private NumericUpDown nud_orderQuantitytoPay;
        private TextBox txt_OrderProdID;
        private Label label_totalPrice;
        private Label label18;
        private Label label_totalPriceValue;
        private Button btn_backToAdmin;
    }
}