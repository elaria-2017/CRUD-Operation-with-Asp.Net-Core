using Lend_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lend_CRUD.Data
{//da zwdnah 34an connection el database
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }
        public DbSet<item> items { get; set; }
        public DbSet<Expense> Expenses {get; set;}
    }
}
