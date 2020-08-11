using System;
using System.Collections.Generic;
using System.Text;
using AW2017.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AW2017.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sale> Sales{ get; set; }
    }
}
