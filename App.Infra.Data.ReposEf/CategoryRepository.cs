using App.Domain.core;
using App.Domain.core.Datas.EfRipository;
using App.Domain.core.Dtos.CategoryDto;
using App.Domain.core.Dtos.ProductDto;
using App.Domain.core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.ReposEf
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


        /// <summary>
        /// Retrun type is removed category Id ,------Is it usable??-------
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<int> Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            category.IsRemoved = true;
            int result = await _context.SaveChangesAsync();
            if (result != 0)
                return category.Id;

            return 0;
        }

        public async Task<List<CategoryOutPutDto>> GetAll()
        {
            var CategoriesList = await _context.Categories.AsNoTracking().Select(c => new CategoryOutPutDto
            {
                Id = c.Id,
                Title = c.Title,
                HasProducts = c.HasProducts,
                ParentId= c.ParentId,

            }).ToListAsync();
            return CategoriesList;
        }

        public async Task<CategoryOutPutDto> GetById(int categoryId)
        {
            var category =  await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
            var categoryDto = new CategoryOutPutDto
            {
                Id = category.Id,
                Title = category.Title,
                HasProducts = category.HasProducts,
                ParentId = category.ParentId,
            };

            return categoryDto;
        }

        public async Task<CategoryWithProductOutputDto> GetWithProducts(int categoryId)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
            var categoryDto = new CategoryWithProductOutputDto
            {
                Id = category.Id,
                Title = category.Title,
                HasProducts = category.HasProducts,
                ParentId = category.ParentId,
                Products = category.Products.ToList(),
            };

            return categoryDto;

        }

        public async Task<int> Update(CategoryEditDto categoryDto)
        {
            var category = await _context.Categories.FindAsync(categoryDto.Id);

            category.Title = categoryDto.Title;
            category.HasProducts = categoryDto.HasProducts;
            category.ParentId = categoryDto.ParentId;

            int result = await _context.SaveChangesAsync();
            if (result != 0)
                return category.Id;

            return 0;

        }

    }
}
