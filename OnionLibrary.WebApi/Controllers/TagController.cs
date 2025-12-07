using AutoMapper;

using OnionLibrary.WebApi.Models.RequestModels.Tags;
using OnionLibrary.WebApi.Models.ResponseModels.Tags;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Application.ManagerInterfaces;
using OnionLibrary.WebApi.Models.RequestModels.Tags;

namespace OnionLibrary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagManager _tagManager;
        private readonly IMapper _mapper;

        public TagController(ITagManager tagManager, IMapper mapper)
        {
            _tagManager = tagManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {

            List<TagDto> values = await _tagManager.GetAllAsync();
            return Ok(_mapper.Map<List<TagResponseModel>>(values));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTag(int id)
        {
            TagDto value = await _tagManager.GetByIdAsync(id);
            return Ok(_mapper.Map<TagResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagRequestModel model)
        {
            TagDto tag = _mapper.Map<TagDto>(model);
            await _tagManager.CreateAsync(tag);
            return Ok("Tag eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagRequestModel model)
        {
            TagDto tag = _mapper.Map<TagDto>(model);
            await _tagManager.UpdateAsync(tag);
            return Ok("Tag güncellendi");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> SoftDeleteTag(int id)
        {
            string mesaj = await _tagManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> HardDeleteTag(int id)
        {
            string mesaj = await _tagManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}
