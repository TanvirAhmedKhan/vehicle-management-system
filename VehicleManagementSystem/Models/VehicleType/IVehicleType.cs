using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public interface IVehicleType
    {
        string VehicleType { get; set; }
    }
}
