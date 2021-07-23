using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TutorialApp.Models;

namespace TutorialApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TutorialApp.Models.Joke> Joke { get; set; }
        public DbSet<TutorialApp.Models.Cars> Cars { get; set; }
    }
}
