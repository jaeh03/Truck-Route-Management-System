using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JH_LAB1.Models
{
    public class TruckWorkshop
    {
        [Key]
        public int WorkOrderID { get; set; }
        public string? workDescription { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double cost { get; set; }
        public int Truck_ID { get; set; }
    }
}
