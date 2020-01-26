using Models;
using System.Linq;

namespace RealServices
{
    public class HotelService : Interfaces.IHotelsService
    {
        public PagedResult<HotelModel> GetHotels()
        {
            using (Context.HotelsContext c = new Context.HotelsContext())
            {
                var data = from h in c.Hotel.AsEnumerable() select new HotelModel(h.Id, h.Name, h.City, h.Address, h.Rating);
                return new PagedResult<HotelModel>(data.ToArray(), 1);
            }
        }
    }
}
