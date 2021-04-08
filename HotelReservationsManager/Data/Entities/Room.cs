using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Room:BaseEntity
    {
        public int Capacity { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public bool IsFree { get; set; }
        public double PriceAdult { get; set; }
        public double PriceChild { get; set; }
        public int Number { get; set; }
        
        public Room() { }

        public Room(Room room)
        {
            this.Id = room.Id;
            this.Capacity = room.Capacity;
            this.RoomType = room.RoomType;
            this.IsFree = room.IsFree;
            this.PriceAdult = room.PriceAdult;
            this.PriceChild = room.PriceChild;
            this.Number = room.Number;
        }
    }
}
