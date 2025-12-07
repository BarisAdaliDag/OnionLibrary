using AutoMapper;
using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Application.ManagerInterfaces;
using OnionLibrary.Contract.RepositoryInterfaces;
using OnionLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.InnerInfrastructure.ManagerConcretes
{
    public class BookTagManager(IBookTagRepository repository, IMapper mapper)
         : BaseManager<BookTagDto, BookTag>(repository, mapper), IBookTagManager
    {
        private readonly IBookTagRepository _repository = repository;
    }
}