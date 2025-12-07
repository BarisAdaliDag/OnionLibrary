using OnionLibrary.Domain.Enums;

namespace OnionLibrary.WebApi.Models.ResponseModels.Author
{
    public class AuthorResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DataStatus Status { get; set; }
    }
}
