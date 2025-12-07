using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.DTOClasses
{
    public class CategoryDto : BaseDto
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
