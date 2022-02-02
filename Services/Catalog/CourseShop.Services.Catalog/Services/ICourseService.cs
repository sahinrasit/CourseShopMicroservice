using CourseShop.Services.Catalog.Dtos;
using CourseShop.Shared.Dtos;

namespace CourseShop.Services.Catalog.Services
{
    public interface ICourseService
    {
        Task<Response<List<CourseDto>>> GetAllAsync();
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<Response<CourseDto>> GetByIdAsync(string id);
        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
        Task<Response<List<CourseDto>>> GetByUserIdAsync(string userId);
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
