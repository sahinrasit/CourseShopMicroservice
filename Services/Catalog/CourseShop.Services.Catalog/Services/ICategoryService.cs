using CourseShop.Services.Catalog.Dtos;
using CourseShop.Services.Catalog.Models;
using CourseShop.Shared.Dtos;

namespace CourseShop.Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);
        Task<Response<CategoryDto>> GetByIdAsync(string id);

    }
}
