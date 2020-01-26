using Models;

namespace Interfaces
{
    public interface IHotelsService
    {
        PagedResult<HotelModel> GetHotels();
    }
}
