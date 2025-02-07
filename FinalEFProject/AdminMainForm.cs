using Dapper;
using FinalEFProject.Models;
using Microsoft.Data.SqlClient;


namespace FinalEFProject
{
    public partial class AdminMainForm : Form
    {
        SqlConnection con = new SqlConnection("Server = .; Database = CafeProject; Trusted_Connection = true;trustservercertificate = true");

        CafeContext _context;
        int _id;
        string _role;
        public AdminMainForm(string role)
        {
            InitializeComponent();
            _context = new CafeContext();
            _role = role;
        }
        void CheckRole()
        {
            if (_role == "Employee")
                btn_orderPage.Visible = true;
            else if (_role == "admin")
                btn_addProduct.Visible = true;
        }
        void DisplayUserData()
        {
            dgv_adduser.DataSource = _context.Users.ToList();
            dgv_adduser.Columns["Id"].Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            DisplayUserData();
            CheckRole();
        }
        bool EmptyFields()
        {
            if (txt_username.Text == "" || txt_password.Text == "" || cb_role.Text == "" || cb_status.Text == "")
                return true;
            return false;
        }
        private void btn_adduser_Click(object sender, EventArgs e)
        {
            

            if (EmptyFields())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {


                var userData = con.Query<Users>("select * from Users").ToList();
                if (userData.Count > 0)
                {
                    foreach (var item in userData)
                    {
                        if (txt_username.Text == item.UserName)
                        {
                            MessageBox.Show("This User Name is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                    }
                }
                
                 if (txt_password.Text.Length <= 8)
                    MessageBox.Show("Password should be more than 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Users user2 = new()
                    {
                        UserName = txt_username.Text,
                        Password = txt_password.Text,
                        Role = "Employee",
                        Status = cb_status.Text,
                        Date_Reg = DateTime.Now,
                        Customer_Phone = txt_phone.Text
                    };
                    _context.Add(user2);
                    _context.SaveChanges();
                    MessageBox.Show("Register Successfull", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_username.Text = txt_password.Text = cb_role.Text = cb_status.Text = "";
                    DisplayUserData();
                }

            }
        }
        private void dgv_adduser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_adduser.Rows[e.RowIndex];
            _id = (int)row.Cells["id"].Value;
            Users user = _context.Users.FirstOrDefault(x => x.Id == _id);
            txt_username.Text = user.UserName;
            txt_password.Text = user.Password;
            cb_role.Text = user.Role;
            cb_status.Text = user.Status;
        }
        private void btn_up_Click(object sender, EventArgs e)
        {
            Users user = _context.Users.FirstOrDefault(users => users.Id == _id);
            if (EmptyFields())
                MessageBox.Show("Enter valid data");
            else
            {
                user.UserName = txt_username.Text;
                user.Password = txt_password.Text;
                user.Role = cb_role.Text;
                user.Status = cb_status.Text;
                user.Date_Reg = DateTime.Now;
                user.Customer_Phone = txt_phone.Text;
                _context.SaveChanges();
                MessageBox.Show("Updated");
                DisplayUserData();
                txt_username.Text = txt_password.Text =txt_phone.Text= cb_role.Text = cb_status.Text = "";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Users user = _context.Users.FirstOrDefault(u => u.Id == _id);
                _context.Users.Remove(user);
                _context.SaveChanges();
                MessageBox.Show("Deleted");
                DisplayUserData();
                txt_username.Text = txt_password.Text = cb_role.Text = cb_status.Text = "";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = txt_password.Text = cb_role.Text = cb_status.Text = "";
        }


        private void close_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdminAddProduct adminAddProduct = new AdminAddProduct(_role);
            adminAddProduct.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminDashBoard dashBoard = new AdminDashBoard(_role);
            dashBoard.Show();
            this.Hide();
        }

        private void btn_orderPage_Click(object sender, EventArgs e)
        {
            EmployeeMainForm employeeMainForm = new EmployeeMainForm(_role);
            employeeMainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(_role);
            adminDashBoard.Show();
            this.Hide();
        }
    }
}
