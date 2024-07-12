using CompanyTravelTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyTravelTrackerAPI.Data
{
    public class CompanyTravelTrackerContext : DbContext
    {
        public CompanyTravelTrackerContext(DbContextOptions<CompanyTravelTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<ForthcomingVisitor> ForthcomingVisitors { get; set; }
        public DbSet<OutgoingVisitor> OutgoingVisitors { get; set; }

    }
}
