namespace OnionLibrary.WebApi.Models.RequestModels.Books
{
    public class UpdateBookRequestModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
