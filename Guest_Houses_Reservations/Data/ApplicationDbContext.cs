using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Guest_Houses_Reservations.Models;

namespace Guest_Houses_Reservations.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Guest_Houses_Reservations.Models.House>? House { get; set; }
		public DbSet<Guest_Houses_Reservations.Models.Guest>? Guest { get; set; }
		public DbSet<Guest_Houses_Reservations.Models.Reservation>? Reservation { get; set; }
	}
}