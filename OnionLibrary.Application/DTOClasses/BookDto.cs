using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.DTOClasses
{
    public class BookDto : BaseDto
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
