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
                    
                    string userRole = con.Query<string>($"select ROle from Users where UserName ='{txt_username.Text}' and Password ='{txt_LogPassword.Text}'").FirstOrDefault();
                    if (userRole!=null)
                    {
                    if (userRole == "admin")
                    {
                        AdminMainForm admin = new AdminMainForm(userRole);
                        admin.Show();
                        this.Hide();
                    }
                    else if (userRole == "Employee")
                    {
                        EmployeeMainForm emp = new EmployeeMainForm(userRole);
                        emp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("incorrect data");
                    }       
                }
                    else
                        MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }

