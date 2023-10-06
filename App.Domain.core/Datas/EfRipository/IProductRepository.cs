using App.Domain.core.Dtos.ProductDto;
using App.Domain.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.core.Datas.EfRipository
{
    public interface IProductRepository
    {
        Task<int> Create(ProductAddDto productAddDto);
        Task<int> Update(ProductEditDto productEditDto);
        Task<int> Delete(int productId);
        Task<ProductOutPutDto> GetById(int productId);
        Task<List<ProductOutPutDto>> GetAll();
    }
}
