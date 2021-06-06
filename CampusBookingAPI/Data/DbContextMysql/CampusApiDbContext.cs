using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusBookingAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CampusBookingAPI.DbContextMysql
{
    public class CampusApiDbContext : DbContext
    {
        public CampusApiDbContext(DbContextOptions<CampusApiDbContext> options)
        : base(options)
        {
           
        }
        public DbSet<Rooms> rooms { get; set; }
        public DbSet<Users> users { get; set; }

        public DbSet<Bookings> bookings { get; set; }
        public DbSet<Comments> comments { get; set; }
    }
}
