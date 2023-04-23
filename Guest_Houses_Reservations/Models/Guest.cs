using System.ComponentModel.DataAnnotations;

namespace Guest_Houses_Reservations.Models
{
	public class Guest

	{
		    [Key]
			public int Id { get; set; }
			public string FirstName { get; set; } // име
			public string LastName { get; set; } // фамилия
			public string Phone { get; set; } // телефон
			public virtual List<Reservation> Reservations { get; set; } // списък от резервации

		public Guest()
		{
            Reservations = new List<Reservation>();
        }
    }
}
