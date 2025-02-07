using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFProject.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        public string Customer_Phone { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime Date_Reg { get; set; }
        public virtual List<Orders>? orders { get; set; } = new List<Orders>();
    }
}
