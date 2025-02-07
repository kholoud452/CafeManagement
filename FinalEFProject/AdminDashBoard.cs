using FinalEFProject.Models;


namespace FinalEFProject
{
    public partial class AdminDashBoard : Form
    {
        CafeContext _context;
        string _role;
        public AdminDashBoard(string role)
        {
            InitializeComponent();
            _role = role;
            _context = new CafeContext();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm(_role);
            adminMainForm.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            EmployeeMainForm empMainForm = new EmployeeMainForm(_role);
            empMainForm.Show();
            this.Hide();
        }
        void CheckRole()
        {
            if (_role == "Employee")
                label9.Visible = false;
            else if (_role == "admin")
                label9.Visible = true;
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            CheckRole();
            GetCustomersData();
            GetEmployeesCount();
        }

        void GetCustomersData()
        {
            decimal totalIncome = 0;
            var cusData = _context.Customers.ToList();
            dataGridView1.DataSource = cusData;
            dataGridView1.Columns["Id"].Visible = false;

            label_totalCutomers.Text = cusData.Count.ToString();
            foreach (var item in cusData)
            {
                totalIncome += item.Total_Price;
            }
            label_totalIncome.Text = totalIncome.ToString();

        }

        void GetEmployeesCount()
        {
            int Count = 0;
            var EmopData = _context.Users.ToList();
            foreach (var item in EmopData)
            {
                if(item.Role =="Employee")
                    Count++;
            }
            label_totalEmployees.Text = Count.ToString();
        }
    }
}
