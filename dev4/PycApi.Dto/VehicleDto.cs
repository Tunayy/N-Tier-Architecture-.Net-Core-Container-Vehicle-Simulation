using PycApi.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class VehicleDto
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string VehicleName { get; set; }

        [Required]
        [MaxLength(500)]
        public string VehiclePlate { get; set; }



    }
}
