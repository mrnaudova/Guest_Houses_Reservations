namespace Guest_Houses_Reservations.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		public int GuestId { get; set; }
		public virtual Guest? Guest { get; set; } // потребител, на когото се води резервацията
		public DateTime ReservationDateTime { get; set; } // дата и час на резервацията
		public int HouseId { get; set; }
		public virtual House? House { get; set; } // къща, на която е зададена резервацията
		public string? Description { get; set; } // описание в свободен текст

		// метод, който проверява за конфликти между резервациите
		public bool IsConflictWith(Reservation otherReservation)
		{
			if (this.House != otherReservation.House) // ако резервациите са за различни къщи, няма конфликт
				return false;

			if (this.Guest == otherReservation.Guest) // ако резервациите са на един и същи потребител, няма конфликт
				return false;

			DateTime start1 = this.ReservationDateTime;
			DateTime end1 = start1.AddHours(this.House.DurationInHours); // изчисляваме края на първата резервация

			DateTime start2 = otherReservation.ReservationDateTime;
			DateTime end2 = start2.AddHours(otherReservation.House.DurationInHours); // изчисляваме края на втората резервация

			// ако интервалите на резервациите се припокриват, има конфликт
			if (start1 < end2 && start2 < end1)
				return true;

			return false; // няма конфликт
		}
	}


	
}