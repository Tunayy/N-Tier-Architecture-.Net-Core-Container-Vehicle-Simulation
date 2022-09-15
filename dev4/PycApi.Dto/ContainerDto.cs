using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class ContainerDto    
    {

        
        [Required]
        public long Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string ContainerName { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public long VehicleId { get; set; }

    }
}
