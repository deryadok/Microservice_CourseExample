using Course.Services.Catalog.Dtos;
using Course.Services.Catalog.Model;
using Course.Shared.Dtos;

namespace Course.Services.Catalog.Services
{
    interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);

        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
