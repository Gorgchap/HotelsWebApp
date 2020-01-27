using Models; using System.Linq;

namespace RealServices
{
    public class HotelService : Interfaces.IHotelsService
    {
        public PagedResult<HotelModel> GetHotels(int page = 1, int len = 5)
        {
            using (Context.HotelsContext c = new Context.HotelsContext())
            {
                var d = from h in c.Hotel.AsEnumerable() select new HotelModel(h.Id, h.Name, h.City, h.Address, h.Rating);
                return new PagedResult<HotelModel>(d.Skip((page - 1) * len).Take(len).ToArray(), d.Count() % len == 0 ? d.Count() / len : d.Count() / len + 1);
            }
        }
    }
}
