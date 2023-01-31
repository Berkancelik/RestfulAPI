using Microsoft.EntityFrameworkCore;
using RestfulAPI.Models;

namespace RestfulAPI.DataContext
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }

        public DbSet<Posts> Posts { get; set; } 
    }
}
