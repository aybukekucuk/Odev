using BlazorProject.Shared;

namespace BlazorProject.Server.Models
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Categories>> GetCategories();
        Task<Categories> GetCategories(int categoryId);
    }
}
