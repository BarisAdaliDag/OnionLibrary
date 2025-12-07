using AutoMapper;

using OnionLibrary.WebApi.Models.ResponseModels.BookTags;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Application.ManagerInterfaces;
using OnionLibrary.WebApi.Models.RequestModels.BookTags;

namespace OnionLibrary.WebApi.Controllers
{
    
    [Route("api/[controller]s")]
    [ApiController]
    public class BookTagController : ControllerBase
    {
        private readonly IBookTagManager _bookTagManager;
        private readonly IMapper _mapper;

        public BookTagController(IBookTagManager bookTagManager, IMapper mapper)
        {
            _bookTagManager = bookTagManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookTags()
        {
              List<BookTagDto> values = await _bookTagManager.GetAllAsync();
           
            return Ok(_mapper.Map<List<BookTagResponseModel>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookTag(CreateBookTagRequestModel model)
        {
            BookTagDto bookTag = _mapper.Map<BookTagDto>(model);
            await _bookTagManager.CreateAsync(bookTag);
            return Ok("Kitaba tag eklendi");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PacifyBookTag(int id){
            await _bookTagManager.SoftDeleteAsync(id);
            return Ok("BookTag soft delete yapildi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookTag(int id)
        {
            await _bookTagManager.HardDeleteAsync(id);
            return Ok("BookTag silindi");
        }
    }
}
