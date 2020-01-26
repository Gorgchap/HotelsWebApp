using Models;

namespace TestServices
{
    class TestHotelsService : Interfaces.IHotelsService
    {
        public HotelModel[] GetHotels()
        {
            throw new System.NotImplementedException();
        }

        public PagedResult<HotelModel> GetPagedHotels(int page, int pagecount)
        {
            throw new System.NotImplementedException();
        }
    }
}
