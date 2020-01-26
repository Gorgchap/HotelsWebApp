using Models;

namespace Interfaces
{
    public interface IHotelsService
    {
        HotelModel[] GetHotels();
        PagedResult<HotelModel> GetPagedHotels(int page, int pagecount);
    }
}
