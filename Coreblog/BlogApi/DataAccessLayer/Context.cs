using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//context nesnesinde veri tabanı bağlantsı yaptık.
            optionsBuilder.UseSqlServer("server=LAPTOP-SMH0TJGI\\SQLEXPRESS; database=CoreBlogApiDb; integrated security=true;");

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
