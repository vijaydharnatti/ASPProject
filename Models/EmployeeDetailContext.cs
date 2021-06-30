using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC1Application.Models
{
    public class EmployeeDetailContext:DbContext
    {
        //public EmployeeDetailContext()
        //{

        //}
        public EmployeeDetailContext(DbContextOptions<EmployeeDetailContext> option):base(option)
        {
                
        }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
          //  optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=EmployeeDB;Integrated Security=True;");
        }

    }
}
