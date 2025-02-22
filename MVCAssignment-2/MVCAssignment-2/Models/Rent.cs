using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssignment_2.Models
{
    public class Rent
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string HallOwner { get; set; }
        [Required]
        public int CostPerDay { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        

        public int TotalRent { get; set; }

    }
}
