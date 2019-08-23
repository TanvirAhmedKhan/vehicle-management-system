using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Models.BodyType;
using VehicleManagementSystem.Models.VehicleType;

namespace VehicleManagementSystem.Data
{
    public class VehicleContext:DbContext
    {
        public VehicleContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<BodyTypes> bodyTypes { get; set; }

    }
}
