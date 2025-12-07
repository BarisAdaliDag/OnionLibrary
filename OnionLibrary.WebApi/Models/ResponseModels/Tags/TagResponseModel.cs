using OnionLibrary.Domain.Enums;


namespace OnionLibrary.WebApi.Models.ResponseModels.Tags
{
    public class TagResponseModel
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public DataStatus Status { get; set; }
    }
}
