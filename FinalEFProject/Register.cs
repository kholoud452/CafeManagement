using Dapper;
using FinalEFProject.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalEFProject
{
    public partial class Register : Form
    {
        CafeContext context;
        SqlConnection con = new SqlConnection("Server = .; Database = CafeProject; Trusted_Connection = true;trustservercertificate = true");

        public Register()
        {
            InitializeComponent();
            context = new CafeContext();
            
        }

        public bool EmptyFields()
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_conPass.Text == "")
                return true;
            return false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logfromreg_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = check_pass.Checked ? '\0' : '*';
            txt_conPass.PasswordChar = check_pass.Checked ? '\0' : '*';
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
                MessageBox.Show("All fields are required to be filled.","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                
                   
                    var userData = con.Query<Users>("select * from Users").ToList();
                    if (userData.Count > 0) { 
                       foreach (var item in userData)
                       {
                            if (txt_username.Text == item.UserName)
                            {
                                 MessageBox.Show("This User Name is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 break;
                            }
                            
                       }
                    }
                    if (txt_password.Text != txt_conPass.Text)
                        MessageBox.Show("Password doesn't match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (txt_password.Text.Length <= 8)
                        MessageBox.Show("Password should be more than 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Users user2 = new()
                        {
                            UserName = txt_username.Text,
                            Password = txt_password.Text,
                            Role = "Employee",
                            Status = "Active",
                            Date_Reg = DateTime.Now,
                            Customer_Phone = txt_phoneNumber.Text
                        };
                        context.Add(user2);
                        context.SaveChanges();
                        MessageBox.Show("Register Successfull","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txt_conPass.Text = txt_password.Text = txt_username.Text = "";
                        Form1 login = new Form1();
                        login.Show();
                        this.Hide();
                    }
               
            }
        }
    }
}
