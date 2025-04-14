using System.ComponentModel.DataAnnotations;

namespace prjICETASK4.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [StringLength(250)]
        public string ProductName { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        
    } 
}
