using AcemStudios.ApiRefactor.DTOs;
using AcemStudios.ApiRefactor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcmeStudios.ApiRefactor.Interfaces
{
    public interface IDataAccessLayer
    {
        public Task<ServiceResponse<List<GetStudioItemDto>>> AddStudioItem(AddStudioItemDto newStudioItem);
        public Task<ServiceResponse<List<GetStudioItemHeaderDto>>> GetAllStudioHeaderItems();
        public Task<ServiceResponse<GetStudioItemDto>> GetStudioItemById(int id);
        public Task<ServiceResponse<GetStudioItemDto>> UpdateStudioItem(UpdateStudioItemDto updatedStudioItem);
        public Task<ServiceResponse<List<GetStudioItemDto>>> DeleteStudioItem(int id);
        public Task<ServiceResponse<List<StudioItemType>>> GetAllStudioItemTypes();
    }
}
