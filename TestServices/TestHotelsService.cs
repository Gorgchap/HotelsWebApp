using Models;

namespace TestServices
{
    public class TestHotelsService : Interfaces.IHotelsService
    {
        public PagedResult<HotelModel> GetHotels(int page = 1, int pageLen = 5)
        {
            return new PagedResult<HotelModel>(new HotelModel[]
            {
                new HotelModel(134, "Bolton Sharks Bay Resort", "Sharm El Sheikh", "15, Sand Beach Nusrani, Bay of Sharks, Egypt", 4),
                new HotelModel(284, "Wonderful Hilton York", "York", "City Centre, 1 Tower Street, York, UK", 5)
            }, 1);
        }
    }
}
