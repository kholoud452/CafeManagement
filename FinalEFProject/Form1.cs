using Dapper;
using FinalEFProject.Models;
using Microsoft.Data.SqlClient;

namespace FinalEFProject
{
    public partial class Form1 : Form
    {
        CafeContext context;
        SqlConnection con = new SqlConnection("Server = .; Database = CafeProject; Trusted_Connection = true;trustservercertificate = true");

        public Form1()
        {
            InitializeComponent();
            context = new CafeContext();
        }

        public bool EmptyFields()
        {
            if (txt_username.Text == "" || txt_LogPassword.Text == "")
                return true;
            return false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_regfromlog_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_LogPassword.PasswordChar = check_pass.Checked ? '\0' : '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                    
                    var userData = con.Query<Users>("select * from Users ").ToList();
                    if (userData.Count > 0)
                    {
                        foreach (var item in userData)
                        {
                            if (txt_username.Text == item.UserName && txt_LogPassword.Text == item.Password)
                            {
                                if(item.Role == "admin")
                                {
                                    AdminMainForm admin = new AdminMainForm(item.Role);
                                    admin.Show();
                                    this.Hide();
                                }
                                else if (item.Role == "Employee")
                                {
                                    EmployeeMainForm emp = new EmployeeMainForm(item.Role);
                                    emp.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("incorrect data");
                                }
                            }
                             

                    }
                }
                else
                    MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
