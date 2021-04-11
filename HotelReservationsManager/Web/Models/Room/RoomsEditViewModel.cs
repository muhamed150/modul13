using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Room
{
    public class RoomsEditViewModel
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public bool IsFree { get; set; }
        public double PriceAdult { get; set; }
        public double PriceChild { get; set; }
        public int Number { get; set; }
        public RoomsEditViewModel() { }
        public RoomsEditViewModel(RoomsEditViewModel room)
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
