using AutoMapper;
using OnionLibrary.WebApi.Models.ResponseModels;
using OnionLibrary.WebApi.Models.ResponseModels.Author;
using OnionLibrary.WebApi.Models.ResponseModels.Books;
using OnionLibrary.WebApi.Models.ResponseModels.Categories;
using OnionLibrary.WebApi.Models.ResponseModels.Tags;
using OnionLibrary.WebApi.Models.ResponseModels.BookTags; 
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.WebApi.Models.RequestModels.Author;
using OnionLibrary.WebApi.Models.RequestModels.Books;
using OnionLibrary.WebApi.Models.RequestModels.BookTags;
using OnionLibrary.WebApi.Models.RequestModels.Categories;
using OnionLibrary.WebApi.Models.RequestModels.Tags;

namespace OnionLibrary.WebApi.MappingProfiles
{
    public class VmMappingProfile : Profile
    {
        public VmMappingProfile()
        {
            CreateMap<CreateAuthorRequestModel, AuthorDto>();
            CreateMap<UpdateAuthorRequestModel, AuthorDto>();
            CreateMap<AuthorDto, AuthorResponseModel>();

            CreateMap<CreateBookRequestModel, BookDto>();
            CreateMap<UpdateBookRequestModel, BookDto>();
            CreateMap<BookDto, BookResponseModel>();

            CreateMap<CreateCategoryRequestModel, CategoryDto>();
            CreateMap<UpdateCategoryRequestModel, CategoryDto>();
            CreateMap<CategoryDto, CategoryResponseModel>();

            CreateMap<CreateTagRequestModel, TagDto>();
            CreateMap<UpdateTagRequestModel, TagDto>();
            CreateMap<TagDto, TagResponseModel>();

            CreateMap<CreateBookTagRequestModel, BookTagDto>();
            CreateMap<BookTagDto, BookTagResponseModel>();
        }
    }
}