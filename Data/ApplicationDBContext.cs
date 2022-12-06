using BulkyBookWeb.Controllers;
using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using Artist = BulkyBookWeb.Models.Artist;

namespace BulkyBookWeb.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)

        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }
}
