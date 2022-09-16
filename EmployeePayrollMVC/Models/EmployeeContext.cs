using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmployeePayRoll.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<EmployeeModel> EmployeeDetails { get; set; }
    }
}