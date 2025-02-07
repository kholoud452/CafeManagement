using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFProject.Models
{
    internal class Products
    {
        [Key]
        public int Id { get; set; }
        public string? Prod_ID { get; set; }
        public string? Prod_Name { get; set; }
        public string? Prod_Type { get; set; }
        public string? Prod_Status { get; set; }
        public int? Prod_Stock { get; set; }
        public decimal? Prod_Price { get;set; }
        public string? Prod_Image { get; set; }
        public DateTime? Date_Insert { get; set; }
        public DateTime? Date_Update { get; set; }
        public DateTime? Date_Delete { get; set; }
    }
}
