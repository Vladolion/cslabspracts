using Microsoft.EntityFrameworkCore;
using pr3.Models;


namespace pr3.Data
{
	public class AppDbContext :DbContext
	{
		public AppDbContext( DbContextOptions<AppDbContext> options ) : base( options ) { }

		public DbSet<Product> Products { get; set; }
	}
}
