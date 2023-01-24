using Microsoft.EntityFrameworkCore;
using MyCars.Entities;
using System.Collections.Generic;

namespace MyCars
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
    }
}
