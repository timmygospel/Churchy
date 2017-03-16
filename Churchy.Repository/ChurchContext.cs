using System.Data.Entity;
using Churchy.Model;
namespace Churchy.Repository
{
    public class ChurchContext : DbContext
    {
        public DbSet<Church> Churches { get; set; }
        public DbSet<Course> Courses { get; set; }

        public ChurchContext() : base("ChurchDb")
        {

        }

    }
}
