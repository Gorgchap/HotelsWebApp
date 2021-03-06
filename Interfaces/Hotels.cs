﻿using Models;

namespace Interfaces
{
    public interface IHotelsService
    {
        PagedResult<HotelModel> GetHotels(int page = 1, int len = 5);
    }
}
