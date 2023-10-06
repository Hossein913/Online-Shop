using App.Domain.core.Dtos.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.core.IService
{
    public interface ICategoryService
    {
        Task<int> Create(CategoryAddDto category);
        Task<int> Update(CategoryEditDto categoryDto);
        Task<int> Delete(int categoryId);
        Task<CategoryOutPutDto> GetById(int categoryId);
        Task<List<CategoryOutPutDto>> GetAll();
        Task<CategoryWithProductOutputDto> GetWithProducts(int categoryId);
    }
}
