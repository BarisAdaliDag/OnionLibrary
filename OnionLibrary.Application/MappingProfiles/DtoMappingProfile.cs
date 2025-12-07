using AutoMapper;
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnionLibrary.Application.MappingProfiles
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<TagDto, Tag>().ReverseMap();
            CreateMap<BookTagDto, BookTag>().ReverseMap();
        }
    }
}
