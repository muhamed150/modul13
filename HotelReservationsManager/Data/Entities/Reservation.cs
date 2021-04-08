using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Reservation:BaseEntity
    {
        public Reservation(Reservation reservation)
        {
            this.Id = reservation.Id;
            this.Room = new Room(reservation.Room);
            this.User = new User(reservation.User);
            this.CheckInDate = reservation.CheckInDate;
            this.CheckOutDate = reservation.CheckOutDate;
            this.IncludedBreakfast = reservation.IncludedBreakfast;
            this.IsAllInclusive = reservation.IsAllInclusive;
            this.FinalPrice = reservation.FinalPrice;
            this.ClientReservations = reservation.ClientReservations;
        }
        public Reservation()
        {
            ClientReservations = new HashSet<ClientReservation>();
        }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IncludedBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }
        public Double FinalPrice { get; set; }
        public ICollection<ClientReservation> ClientReservations { get; set; }
    }
}
