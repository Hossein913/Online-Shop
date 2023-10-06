using App.Domain.core.Dtos.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.core.IAppService
{
    public interface ICategoryAppService
    {
        Task<string> Create(CategoryAddDto category);
        Task<string> Update(CategoryEditDto categoryDto);
        Task<string> Delete(int categoryId);
        Task<CategoryOutPutDto> GetById(int categoryId);
        Task<List<CategoryOutPutDto>> GetAll();
        Task<CategoryWithProductOutputDto> GetWithProducts(int categoryId);
    }
}
