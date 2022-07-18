using Microsoft.EntityFrameworkCore;
using RestaurantService.Models;

namespace RestaurantService.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Menu> Menus { get; set; }

        public static implicit operator ApplicationDbContext(ApplicationBuilder v)
        {
            throw new NotImplementedException();
        }
    }
}
