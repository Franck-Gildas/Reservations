using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Hotel.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
