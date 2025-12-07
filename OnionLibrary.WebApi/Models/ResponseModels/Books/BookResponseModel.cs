using OnionLibrary.Domain.Enums;

namespace OnionLibrary.WebApi.Models.ResponseModels.Books
{
    public class BookResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public DataStatus Status { get; set; }
    }
}
