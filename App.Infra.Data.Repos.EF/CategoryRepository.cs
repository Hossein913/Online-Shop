using App.Domain.core;
using App.Domain.core.Datas.EfRipository;
using App.Domain.core.Dtos.CategoryDto;
using App.Domain.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.EF
{
    public class CategoryRepository : ICategoryRepository
    {


        private readonly Maktab97ShopDbContext _context;
        public CategoryRepository(Maktab97ShopDbContext eshopContext)
        {
            _context = eshopContext;
        }

        public async Task<int> Create(CategoryAddDto categoryAddDto)
        {
            Category category = new Category
            {
                Title = categoryAddDto.Title,
                HasProducts = categoryAddDto.HasProducts,
                ParentId = categoryAddDto.ParentId,
            };

            await _context.Categories.AddAsync(category);
            var result = await _context.SaveChangesAsync();
            if (result != 0)
                return category.Id;

            return 0;
        }

        public async Task<int> Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            category.IsRemoved = true;
            int result = await _context.SaveChangesAsync();
            if (result != 0)
                return 1;

            return 0;
        }

        public async Task<List<CategoryOutputDto>> GetAll()
        {
            return await _context.Categories.AsNoTracking().Select<Category, CategoryOutputDto>(c => new CategoryOutputDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Photo = c.Picture.PictureLink
            }).ToListAsync();
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }

        public async Task Update(Category category)
        {
            _context.Categories.Update(category);
            int number = await _context.SaveChangesAsync();
        }

    }
}
