using OnionLibrary.Domain.Enums;

namespace OnionLibrary.WebApi.Models.ResponseModels.BookTags
{
    public class BookTagResponseModel
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int BookId { get; set; }
        public DataStatus Status { get; set; }
    }
}
