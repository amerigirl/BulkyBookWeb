using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
 

namespace BulkyBookWeb.Data
{
	public class ApplicationDBContext : DbContext //you need to watch some videos about dbcontext!
	{

		//establishess a connection with entity framework
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)

		{

		}

		public DbSet<Category> Categories { get; set; }

	}


}
