using App.Domain.core.Datas.EfRipository;
using App.Domain.core.Dtos.CategoryDto;
using App.Domain.core.Entities;
using App.Domain.core.IAppService;
using App.Domain.core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService categoryService;
        public CategoryAppService(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public async Task<string> Create(CategoryAddDto category)
        {
            int result = await categoryService.Create(category);
            if (result == 1)
                return $"category with title = {category.Title} created successfuly";
            else
                return $"cant create category with title = {category.Title}";
        }

        public async Task<string> Delete(int categoryId)
        {
            int result = await categoryService.Delete(categoryId);
            if (result == 1)
                return $"category with id = {categoryId} deleted successfuly";
            else
                return $"category with id = {categoryId} not found";
        }

        public async Task<List<CategoryOutPutDto>> GetAll()
        {
            var result = await categoryService.GetAll();
            return result;
        }

        public async Task<CategoryOutPutDto> GetById(int categoryId)
        {
            var result = await categoryService.GetById(categoryId);
            return result;
        }

        public async Task<CategoryWithProductOutputDto> GetWithProducts(int categoryId)
        {
            var result = await categoryService.GetWithProducts(categoryId);
            return result;
        }

        public async Task<string> Update(CategoryEditDto categoryDto)
        {
            int result = await categoryService.Update(categoryDto);
            if (result == 1)
                return $"category with id = {categoryDto.Id} edited successfuly";
            else
                return $"category with id = {categoryDto.Id} not found";
        }
    }
}
