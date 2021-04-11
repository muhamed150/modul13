using Data.Entities;

namespace Web.Models.Room
{
    public class RoomsViewModel
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public bool IsFree { get; set; }
        public double PriceAdult { get; set; }
        public double PriceChild { get; set; }
        public int Number { get; set; }

        public RoomsViewModel() { }

        public RoomsViewModel(RoomsViewModel roomViewModel)
        {
            this.Id = roomViewModel.Id;
            this.Capacity = roomViewModel.Capacity;
            this.RoomType = roomViewModel.RoomType;
            this.IsFree = roomViewModel.IsFree;
            this.PriceAdult = roomViewModel.PriceAdult;
            this.PriceChild = roomViewModel.PriceChild;
            this.Number = roomViewModel.Number;
        }
    }
}
