using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Application.ManagerInterfaces;
using OnionLibrary.WebApi.Models.RequestModels.Categories;
using OnionLibrary.WebApi.Models.ResponseModels.Categories;


namespace OnionLibrary.WebApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryManager categoryManager, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            List<CategoryDto> values = await _categoryManager.GetAllAsync();
            return Ok(_mapper.Map<List<CategoryResponseModel>>(values));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            CategoryDto value = await _categoryManager.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestModel model)
        {
            CategoryDto category = _mapper.Map<CategoryDto>(model);
            await _categoryManager.CreateAsync(category);
            return Ok("Kategori eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryRequestModel model)
        {
            CategoryDto category = _mapper.Map<CategoryDto>(model);
            await _categoryManager.UpdateAsync(category);
            return Ok("Kategori güncellendi");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> SoftDeleteCategory(int id)
        {
            string mesaj = await _categoryManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> HardDeleteCategory(int id)
        {
            string mesaj = await _categoryManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}
