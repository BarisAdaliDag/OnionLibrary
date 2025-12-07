using AutoMapper;

using OnionLibrary.WebApi.Models.ResponseModels.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Application.ManagerInterfaces;
using OnionLibrary.WebApi.Models.RequestModels.Books;

namespace OnionLibrary.WebApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookManager _bookManager;
        private readonly IMapper _mapper;

        public BookController(IBookManager bookManager, IMapper mapper)
        {
            _bookManager = bookManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            List<BookDto> values = await _bookManager.GetAllAsync();
            List<BookResponseModel> response = _mapper.Map<List<BookResponseModel>>(values);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            BookDto value = await _bookManager.GetByIdAsync(id);
            return Ok(_mapper.Map<BookResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookRequestModel model)
        {
            BookDto book = _mapper.Map<BookDto>(model);
            await _bookManager.CreateAsync(book);
            return Ok("Kitap eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookRequestModel model)
        {
            BookDto book = _mapper.Map<BookDto>(model);
            await _bookManager.UpdateAsync(book);
            return Ok("Kitap güncellendi");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> SoftDeleteBook(int id)
        {
            string mesaj = await _bookManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> HardDeleteBook(int id)
        {
            string mesaj = await _bookManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}