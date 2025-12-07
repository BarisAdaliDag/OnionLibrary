namespace OnionLibrary.WebApi.Models.RequestModels.Categories
{
    public class CreateCategoryRequestModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}

namespace OnionLibrary.WebApi.RequestModels.Books
{
    public class CreateBookRequestModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
