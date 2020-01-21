using System.Linq;

namespace Context
{
    public class HotelService : IHotelsService
    {

        public HotelModel[] FindMany()
        {
            using (HotelsContext c = new HotelsContext())
            {
                var data = from h in c.Hotel.AsEnumerable()
                           select new HotelModel(h.Id, h.Name, h.City, h.Address, h.Rating, h.ConvHotel);
                return data.ToArray();
            }
        }
    }
}
