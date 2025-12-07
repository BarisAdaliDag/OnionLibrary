using OnionLibrary.Application.DTOClasses;
using OnionLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.ManagerInterfaces
{
    public interface IAuthorManager : IManager<AuthorDto, Author>
    {
    }
}
