using App.Domain.core.Dtos.CategoryDto;
using App.Domain.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.core.Datas.EfRipository
{
    public interface ICategoryRepository
    {
        Task<int> Create(CategoryAddDto category);
        Task<int> Update(CategoryEditDto categoryDto);
        Task<int> Delete(int categoryId);
        Task<CategoryOutPutDto> GetById(int categoryId);
        Task<List<CategoryOutPutDto>> GetAll();
        Task<CategoryWithProductOutputDto> GetWithProducts(int categoryId);

    }
}
