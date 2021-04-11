using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Room
{
    public class RoomsCreateViewModel
    {
        public int Capacity { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public bool IsFree { get; set; }

        [Required]
        public double PriceAdult { get; set; }

        [Required]
        public double PriceChild { get; set; }
        public int Number { get; set; }
        public RoomsCreateViewModel() { }
        public RoomsCreateViewModel(RoomsCreateViewModel room)
        {
            this.Capacity = room.Capacity;
            this.RoomType = room.RoomType;
            this.IsFree = room.IsFree;
            this.PriceAdult = room.PriceAdult;
            this.PriceChild = room.PriceChild;
            this.Number = room.Number;
        }
    }
}
