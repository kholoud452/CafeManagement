using FinalEFProject.Models;


namespace FinalEFProject
{
    public partial class EmpCustomerForm : Form
    {
        CafeContext _context;
        string _role;
        public EmpCustomerForm(string role)
        {
            InitializeComponent();
            _context = new CafeContext();
            _role = role;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void backToOrders_Click(object sender, EventArgs e)
        {
            EmployeeMainForm empMainForm = new EmployeeMainForm(_role);
            empMainForm.Show();
            this.Hide();
        }

        private void EmpCustomerForm_Load(object sender, EventArgs e)
        {
            dgv_allCustomers.DataSource = _context.Customers.ToList();
            dgv_allCustomers.Columns["Id"].Visible = false;
        }
    }
}
