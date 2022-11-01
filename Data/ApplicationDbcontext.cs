using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hoangkhoa001.Models;

namespace Hoangkhoa001.Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options):base(options)
        {
        }
        public DbSet<Hoangkhoa001.Models.Student> Student {get; set;} = default!;
        public DbSet<Hoangkhoa001.Models.Customer>? Customer { get; set; }
        public DbSet<Hoangkhoa001.Models.Person>? Person { get; set; }
        public DbSet<Hoangkhoa001.Models.Employee>? Employee { get; set; }
    }
}