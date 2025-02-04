using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JH_LAB1.Models
{
    public class Route
    {
        [Key]
        public int RouteID { get; set; }
        public string route_name { get; set; } = string.Empty; 
        public double r_length { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double r_pay_per_km { get; set; }
    }
}
