using FinalEFProject.Models;
using System.Data;
using System.Security.Cryptography;


namespace FinalEFProject
{
    public partial class EmployeeMainForm : Form
    {
        CafeContext _context;
        int _orderId;
        int _productId;
        int _customerId = -1;
        string _role;
        decimal totalPrice = 0;
        public EmployeeMainForm(string role)
        {
            InitializeComponent();
            _context = new CafeContext();
            _role = role;
        }
        void LoadDataOfMenu()
        {

            dgv_empMenu.DataSource = _context.Products.Where(p => p.Prod_Status == "Available").ToList();
            dgv_empMenu.Columns["Id"].Visible = false;
            dgv_empMenu.Columns["Prod_Image"].Visible = false;
            dgv_empMenu.Columns["Date_Insert"].Visible = false;
            dgv_empMenu.Columns["Date_Update"].Visible = false;
            dgv_empMenu.Columns["Date_Delete"].Visible = false;

        }
        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            LoadDataOfMenu();
            if(_role == "Employee")
                btn_backToAdmin.Visible = false;

        }
        void CheckCustomerPhone()
        {

            var user = _context.Users.Where(p => p.Customer_Phone == txt_cusPhone.Text && p.Role == "User").FirstOrDefault();
            if (user != null)
                _customerId = user.Id;
            else _customerId = -1;
            if (_customerId != -1)
            {
                GetOrderData(_customerId);
            }
            else
            {
                MessageBox.Show("This user don't exist \n Go to add user...", "Confirmation Message");

               AdminMainForm form = new AdminMainForm(_role);
                form.Show();
                this.Hide();
            }
        }

        private void addProduct_btn_Click_1(object sender, EventArgs e)
        {
            AdminAddProduct adminAddProduct = new AdminAddProduct(_role);
            adminAddProduct.Show();
            this.Hide();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        private void cb_empType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_empProdID.Text = "";
            string selectedValue = cb_empType.SelectedItem as string;
            if (selectedValue != null)
                cb_empProdID.DataSource = _context.Products.Where(i => i.Prod_Type == selectedValue).Select(p => p.Prod_ID).ToList();
        }

        private void cb_empProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cb_empProdID.SelectedItem as string;
            var product = _context.Products.FirstOrDefault(p => p.Prod_ID == selectedValue);

            label_menuProdName.Text = product.Prod_Name;
            label_priceMenu.Text = product.Prod_Price.ToString();

        }

        private void btn_menuAdd_Click(object sender, EventArgs e)
        {
            if (cb_empProdID.Text == "" && cb_empProdID.Text == "" && label_priceMenu.Text == ""
                && label_menuProdName.Text == "" && nud_quantity.Value == 0)
                MessageBox.Show("Please the Product first");
            else
            {
                try
                {
                    Orders orders = new Orders()
                    {
                        Order_Date = DateTime.Now,
                        Prod_Type = cb_empType.Text,
                        Prod_Id = cb_empProdID.Text,
                        Prod_Name = label_menuProdName.Text,
                        Price = decimal.Parse(label_priceMenu.Text) * (int)nud_quantity.Value,
                        Order_Quantity = (int)nud_quantity.Value,
                        UserId = _customerId
                    };
                    _context.Orders.Add(orders);
                    _context.SaveChanges();
                    cb_empProdID.Text = cb_empProdID.Text = label_priceMenu.Text =
                     label_menuProdName.Text = ""; nud_quantity.Value = 0;
                    MessageBox.Show("Order Added");
                    GetOrderData(_customerId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        
        void GetOrderData(int customerId)
        {
            var orderTable = _context.Orders.Where(o => o.UserId == customerId).ToList();
            dgv_displayOrderData.DataSource = orderTable;
            dgv_displayOrderData.Columns["Id"].Visible = false;
            dgv_displayOrderData.Columns["Order_Delete_Date"].Visible = false;
            dgv_displayOrderData.Columns["Order_Date"].Visible = false;
            dgv_displayOrderData.Columns["User"].Visible = false;


            foreach (var item in orderTable)
            {
                totalPrice += item.Price;
            }
            if (totalPrice != 0)
                label_totalPriceValue.Text = totalPrice.ToString();
            else
                label_orderPrice.Text = "";
        }
        private void dgv_empMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_empMenu.Rows[e.RowIndex];
            _productId = (int)row.Cells["id"].Value;
            Products selectedProduct = _context.Products.FirstOrDefault(p => p.Id == _productId);
            if (selectedProduct != null)
            {
                cb_empProdID.Text = selectedProduct.Prod_ID;
                cb_empType.Text = selectedProduct.Prod_Type;
                label_priceMenu.Text = selectedProduct.Prod_Price.ToString();
                label_menuProdName.Text = selectedProduct.Prod_Name;
            }
        }

        private void btn_CheckCustomerExist_Click(object sender, EventArgs e)
        {
            CheckCustomerPhone();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal getAmount = decimal.Parse(txt_amount.Text);
                decimal getChange = getAmount - totalPrice;
                if (getChange > 0)
                    label_change.Text = getChange.ToString();
                else
                {
                    txt_amount.Text = "";
                    label_change.Text = "";
                    MessageBox.Show("invalid");
                }
            }
        }

        private void btn_orderPay_Click(object sender, EventArgs e)
        {
            if (dgv_displayOrderData.Rows.Count < 0 && txt_amount.Text == "")
                MessageBox.Show("Something went wrong");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Pay", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Customers customers = new Customers()
                    {
                        Customer_Id = _customerId,
                        Total_Price = totalPrice,
                        Amount = decimal.Parse(txt_amount.Text),
                        Change = decimal.Parse(label_change.Text),
                        Date = DateTime.Now,
                    };
                    _context.Customers.Add(customers);
                    _context.SaveChanges();
                    var allOrderData = _context.Orders.ToList();
                    _context.RemoveRange(allOrderData);
                    _context.SaveChanges();
                    MessageBox.Show("Successfull Payment");
                    GetOrderData(_customerId);
                    label_orderPrice.Text = label_totalPriceValue.Text = txt_amount.Text = label_change.Text = "";

                }
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            EmpCustomerForm empCustomerForm = new EmpCustomerForm(_role);
            empCustomerForm.Show();
            this.Hide();
        }

        private void btn_menuClear_Click(object sender, EventArgs e)
        {
            cb_empProdID.Text = cb_empProdID.Text = label_priceMenu.Text =
                     label_menuProdName.Text = ""; nud_quantity.Value = 0;
        }

        private void dgv_displayOrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_displayOrderData.Rows[e.RowIndex];
            _orderId = (int)row.Cells["id"].Value;
            var orderData = _context.Orders.Where(o => o.Id == _orderId).FirstOrDefault();
            txt_OrderProdID.Text = orderData.Prod_Id;
            nud_orderQuantitytoPay.Value = (int)orderData.Order_Quantity;
            label_orderPrice.Text = orderData.Price.ToString();
        }

        private void btn_delOrder_Click(object sender, EventArgs e)
        {
            var delOrder = _context.Orders.FirstOrDefault(o => o.Id == _orderId);
            if (delOrder != null)
            {
                _context.Remove(delOrder);
                _context.SaveChanges();
                GetOrderData(_customerId);
                txt_OrderProdID.Text = label_orderPrice.Text = "";
                nud_orderQuantitytoPay.Value = 0;
            }
        }

        private void btn_backToAdmin_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm(_role);
            adminMainForm.Show();
            this.Hide();
        }
    }
}
