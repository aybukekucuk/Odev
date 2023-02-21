using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Server.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Categories> GetCategories(int categoryId)
        {
            return await appDbContext.Categories
                .FirstOrDefaultAsync(c => c.CategoryID == categoryId);
        }

        public async Task<IEnumerable<Categories>> GetCategories()
        {
            return await appDbContext.Categories.ToListAsync();
        }
    }
}
