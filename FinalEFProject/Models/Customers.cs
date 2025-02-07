using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFProject.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public decimal Total_Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Change { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Orders> orders { get; set; } = new List<Orders>();
    }
}
