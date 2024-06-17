using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymApp.Models;

namespace GymApp.Data
{
    public class GymAppDBContext : DbContext
    {
        public GymAppDBContext (DbContextOptions<GymAppDBContext> options)
            : base(options)
        {
        }

        public DbSet<GymApp.Models.Member> Member { get; set; } = default!;

        public DbSet<GymApp.Models.User>? User { get; set; }
    }
}
