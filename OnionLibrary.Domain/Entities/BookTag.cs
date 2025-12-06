using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Domain.Entities
{
    public class BookTag : BaseEntity
    {
        // Composite Primary Key 
        public int BookId { get; set; }
        public int TagId { get; set; }

        // Relational Properties
        public virtual Book Book { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
