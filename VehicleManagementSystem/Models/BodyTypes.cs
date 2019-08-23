using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models.BodyType
{
    public class BodyTypes: IBodyType
    {
        [Key]
        public int Id { get; set; }
        public string VehicleType { get; set; }
        public string BodyType { get; set; }
    }
}
