
using Microsoft.EntityFrameworkCore;
using StellantisSupportAPI.Models;
using System.Collections.Generic;


namespace StellantisSupportAPI.Data
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
