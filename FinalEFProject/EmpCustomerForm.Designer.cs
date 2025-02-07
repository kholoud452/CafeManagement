namespace FinalEFProject
{
    partial class EmpCustomerForm
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
            backToOrders = new Label();
            Close = new Label();
            panel4 = new Panel();
            dgv_allCustomers = new DataGridView();
            label9 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_allCustomers).BeginInit();
            SuspendLayout();
            // 
            // backToOrders
            // 
            backToOrders.AutoSize = true;
            backToOrders.Font = new Font("Arial Narrow", 12F);
            backToOrders.Location = new Point(66, 9);
            backToOrders.Name = "backToOrders";
            backToOrders.Size = new Size(66, 24);
            backToOrders.TabIndex = 9;
            backToOrders.Text = "< Order";
            backToOrders.Click += backToOrders_Click;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Close.Location = new Point(1127, 9);
            Close.Name = "Close";
            Close.Size = new Size(22, 23);
            Close.TabIndex = 8;
            Close.Text = "X";
            Close.Click += Close_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dgv_allCustomers);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(24, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(1186, 618);
            panel4.TabIndex = 10;
            // 
            // dgv_allCustomers
            // 
            dgv_allCustomers.AllowUserToAddRows = false;
            dgv_allCustomers.AllowUserToDeleteRows = false;
            dgv_allCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_allCustomers.BackgroundColor = Color.White;
            dgv_allCustomers.BorderStyle = BorderStyle.None;
            dgv_allCustomers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_allCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_allCustomers.ColumnHeadersHeight = 29;
            dgv_allCustomers.EnableHeadersVisualStyles = false;
            dgv_allCustomers.Location = new Point(13, 57);
            dgv_allCustomers.Name = "dgv_allCustomers";
            dgv_allCustomers.ReadOnly = true;
            dgv_allCustomers.RowHeadersVisible = false;
            dgv_allCustomers.RowHeadersWidth = 51;
            dgv_allCustomers.Size = new Size(1160, 543);
            dgv_allCustomers.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 16);
            label9.Name = "label9";
            label9.Size = new Size(154, 27);
            label9.TabIndex = 2;
            label9.Text = "All Customrs";
            // 
            // EmpCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 698);
            Controls.Add(panel4);
            Controls.Add(backToOrders);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpCustomerForm";
            Text = "EmpCustomerForm";
            Load += EmpCustomerForm_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_allCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backToOrders;
        private Label Close;
        private Panel panel4;
        private DataGridView dgv_allCustomers;
        private Label label9;
    }
}