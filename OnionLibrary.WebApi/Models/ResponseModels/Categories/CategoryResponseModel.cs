using OnionLibrary.Domain.Enums;

namespace OnionLibrary.WebApi.Models.ResponseModels.Categories
{
    public class CategoryResponseModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DataStatus Status { get; set; }
    }
}
