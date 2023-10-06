using App.Domain.core.Dtos.CategoryDto;
using App.Domain.core.Dtos.ProductDto;
using App.Domain.core.IAppService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.EndPoints.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;
        public CategoryController(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory(CategoryAddDto category)
        {
            var msg = await _categoryAppService.Create(category);
            return Ok(msg);
        }

        [HttpPost("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var msg = await _categoryAppService.Delete(id);
            return Ok(msg);
        }

        [HttpPost("EditCategory")]
        public async Task<IActionResult> EditCategory(CategoryEditDto categoryDto)
        {
            var msg = await _categoryAppService.Update(categoryDto);
            return Ok(msg);
        }

        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            var categories = await _categoryAppService.GetAll();
            return Ok(categories);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryAppService.GetById(id);
            return Ok(category);
        }
    }
}
