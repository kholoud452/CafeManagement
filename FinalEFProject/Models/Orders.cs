using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFProject.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public string Prod_Id { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Type { get; set; }
        public decimal Price { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Order_Delete_Date { get; set; }
        public int Order_Quantity { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual  Users User { get; set; }
    }
}
