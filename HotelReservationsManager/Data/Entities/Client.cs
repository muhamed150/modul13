using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Client: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
        public virtual ICollection<ClientReservation> ClientReservations { get; set; }
        public Client() { }
        public Client(Client client)
        {
            this.Id = client.Id;
            this.FirstName = client.FirstName;
            this.LastName = client.LastName;
            this.PhoneNumber = client.PhoneNumber;
            this.Email = client.Email;
            this.IsAdult = client.IsAdult;
            this.ClientReservations = client.ClientReservations;
        }

    }
}
