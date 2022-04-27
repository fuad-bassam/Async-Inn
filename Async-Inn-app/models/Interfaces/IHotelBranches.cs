using Async_Inn_app.models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
   public interface IHotelBranches
    {


        Task<HotelBranchesDTO> Create(HotelBranchesDTO hotelBranchesDTO);
        Task<List<HotelBranchesDTO>> GetHotels();
        Task<HotelBranchesDTO> GetHotel(int id);
        Task<HotelBranchesDTO> UpdateHotel(int id, HotelBranchesDTO hotelBranchesDTO);
        Task Delete(int id);



    }
}
