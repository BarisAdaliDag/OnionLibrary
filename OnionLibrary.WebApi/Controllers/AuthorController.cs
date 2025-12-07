using AutoMapper;
using OnionLibrary.WebApi.Models.ResponseModels.Author;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Application.ManagerInterfaces;
using OnionLibrary.WebApi.Models.RequestModels.Author;

namespace OnionLibrary.WebApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorManager _authorManager;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorManager authorManager, IMapper mapper)
        {
            _authorManager = authorManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            List<AuthorDto> values =  await _authorManager.GetAllAsync();
            List<AuthorResponseModel> response = _mapper.Map<List<AuthorResponseModel>>(values);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            AuthorDto value = await _authorManager.GetByIdAsync(id);
            return Ok(_mapper.Map<AuthorResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorRequestModel model)
        {
            AuthorDto author = _mapper.Map<AuthorDto>(model);
            await _authorManager.CreateAsync(author);
            return Ok("Yazar eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorRequestModel model)
        {
            AuthorDto author = _mapper.Map<AuthorDto>(model);
            await _authorManager.UpdateAsync(author);
            return Ok("Yazar güncellendi");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> SoftDeleteAuthor(int id)
        {
            string mesaj = await _authorManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> HardDeleteAuthor(int id)
        {
            string mesaj = await _authorManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}
