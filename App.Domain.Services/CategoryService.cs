using App.Domain.core.Datas.EfRipository;
using App.Domain.core.Dtos.CategoryDto;
using App.Domain.core.Entities;
using App.Domain.core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<int> Create(CategoryAddDto category)
        {
            int result = await categoryRepository.Create(category);
            return result;
        }

        public async Task<int> Delete(int categoryId)
        {
            int result = await categoryRepository.Delete(categoryId);
            return result;
        }

        public async Task<List<CategoryOutPutDto>> GetAll()
        {
            var result = await categoryRepository.GetAll();
            return result;
        }

        public async Task<CategoryOutPutDto> GetById(int categoryId)
        {
            var result = await categoryRepository.GetById(categoryId);
            return result;
        }

        public async Task<CategoryWithProductOutputDto> GetWithProducts(int categoryId)
        {
            var result = await categoryRepository.GetWithProducts(categoryId);
            return result;
        }

        public async Task<int> Update(CategoryEditDto categoryDto)
        {
            var result = await categoryRepository.Update(categoryDto);
            return result;
        }
    }
}
