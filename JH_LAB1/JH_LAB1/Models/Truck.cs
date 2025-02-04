using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JH_LAB1.Models
{
    public class Truck
    {
        [Key]
        public int Truck_ID { get; set; }
        public string t_model { get; set; } = string.Empty;
        public string t_make { get;set; } = string.Empty;

        public int RouteID { get; set; } 
    }
}
