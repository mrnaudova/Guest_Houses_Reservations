namespace Guest_Houses_Reservations.Models
{
	public class House
	{

		public int Id { get; set; } // номер на къщата
		public int Capacity { get; set; } // брой места
		public bool SmokingAllowed { get; set; } // пушачи - да/не
		public bool PetsAllowed { get; set; } // домашни любимци - да/не
		public decimal NightlyPrice { get; set; } // цена за нощувка
		public double DurationInHours { get; internal set; }
	}
}
