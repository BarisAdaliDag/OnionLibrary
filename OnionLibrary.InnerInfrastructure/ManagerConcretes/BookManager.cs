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
    public class BookManager(IBookRepository repository, IMapper mapper)
         : BaseManager<BookDto, Book>(repository, mapper), IBookManager
    {
        private readonly IBookRepository _repository = repository;
    }
}