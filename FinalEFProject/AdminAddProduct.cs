using FinalEFProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalEFProject
{
    public partial class AdminAddProduct : Form
    {
        CafeContext _context;
        int _productId;
        string imagePath = "";
        string _role;
        public AdminAddProduct(string role)
        {
            InitializeComponent();
            _context = new CafeContext();
            _role = role;
        }

        private void AdminAddProduct_Load(object sender, EventArgs e)
        {
            LoadProductData();
            CheckRole();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        public void LoadProductData()
        {
            dgv_displayProd.DataSource = _context.Products.ToList();
            dgv_displayProd.Columns["Id"].Visible = false;
        }
        bool EmptyFields()
        {
            if (txt_productId.Text == "" && txt_productName.Text == "" && txt_stock.Text == "" && txt_price.Text == "")
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
        private void btn_addprod_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
                MessageBox.Show("Fill All Data");
            else
            {
                try
                {
                    Products products = new Products()
                    {
                        Prod_ID = txt_productId.Text,
                        Prod_Name = txt_productName.Text,
                        Prod_Price = decimal.Parse(txt_price.Text),
                        Prod_Stock = int.Parse(txt_stock.Text),
                        Prod_Type = cb_type.Text,
                        Prod_Status = cb_status.Text,
                        Prod_Image = imagePath,
                        Date_Insert = DateTime.Now
                    };
                    _context.Products.Add(products);
                    _context.SaveChanges();
                    MessageBox.Show("Added");
                    LoadProductData();
                    txt_productId.Text = txt_productName.Text = txt_stock.Text = txt_price.Text = cb_status.Text = cb_type.Text = "";
                    pictureBox1.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_displayProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_displayProd.Rows[e.RowIndex];
            _productId = (int)row.Cells["id"].Value;
            Products product = _context.Products.FirstOrDefault(p => p.Id == _productId);
            if (product != null)
            {
                txt_productId.Text = product.Prod_ID;
                txt_productName.Text = product.Prod_Name;
                txt_stock.Text = product.Prod_Stock.ToString();
                txt_price.Text = product.Prod_Price.ToString();
                cb_status.Text = product.Prod_Status;
                cb_type.Text = product.Prod_Type;
                if (!string.IsNullOrEmpty(product.Prod_Image))
                {
                    pictureBox1.Image = Image.FromFile(product.Prod_Image);
                }
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            Products product = _context.Products.FirstOrDefault(p => p.Id == _productId);
            if (product != null && !EmptyFields())
            {
                product.Prod_ID = txt_productId.Text;
                product.Prod_Name = txt_productName.Text;
                product.Date_Update = DateTime.Now;
                product.Prod_Price = decimal.Parse(txt_price.Text);
                product.Prod_Stock = int.Parse(txt_stock.Text);
                product.Prod_Status = cb_status.Text;
                product.Prod_Type = cb_type.Text;
                if (!string.IsNullOrEmpty(product.Prod_Image))
                {
                    pictureBox1.Image = Image.FromFile(product.Prod_Image);
                }
                _context.SaveChanges();
                MessageBox.Show("updated");
                LoadProductData();
                txt_productId.Text = txt_productName.Text = txt_stock.Text = txt_price.Text = cb_status.Text = cb_type.Text = "";
                pictureBox1.Image = null;
            }
            else
                MessageBox.Show("Enter valid data");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Products product = _context.Products.FirstOrDefault(p => p.Id == _productId);
                if (product != null)
                {

                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    MessageBox.Show("Deleted");
                    LoadProductData();
                    txt_productId.Text = txt_productName.Text = txt_stock.Text = txt_price.Text = cb_status.Text = cb_type.Text = "";
                    pictureBox1.Image = null;
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_productId.Text = txt_productName.Text = txt_stock.Text =
            txt_price.Text = cb_status.Text = cb_type.Text = "";
            pictureBox1.Image = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm(_role);
            adminMainForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EmployeeMainForm empMainForm = new EmployeeMainForm(_role);
            empMainForm.Show();
            this.Hide();
        }

        void CheckRole()
        {
            if (_role == "Employee")
                label4.Visible = false;
            else if (_role == "admin")
                label4.Visible = true;
        }
    }
}
