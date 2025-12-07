using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionLibrary.Domain.Entities;
using OnionLibrary.Persistence.Configurations.OnionLibrary.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Persistence.Configurations
{
    public class BookTagConfiguration : BaseConfiguration<BookTag>
    {
        public override void Configure(EntityTypeBuilder<BookTag> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            // BookId ve TagId birlikte unique olsun
            builder.HasIndex(x => new { x.BookId, x.TagId })
                   .IsUnique();

            // Foreign Key relationships
            builder.HasOne(x => x.Book)
                   .WithMany(x => x.BookTags)
                   .HasForeignKey(x => x.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Tag)
                   .WithMany(x => x.BookTags)
                   .HasForeignKey(x => x.TagId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}