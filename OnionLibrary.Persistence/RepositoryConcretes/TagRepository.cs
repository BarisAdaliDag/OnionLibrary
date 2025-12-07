using OnionLibrary.Contract.RepositoryInterfaces;
using OnionLibrary.Domain.Entities;
using OnionLibrary.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Persistence.RepositoryConcretes
{
    public class TagRepository(MyContext context)
        : BaseRepository<Tag>(context), ITagRepository
    {
    }

}
