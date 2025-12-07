using Microsoft.Extensions.DependencyInjection;
using OnionLibrary.Contract.RepositoryInterfaces;
using OnionLibrary.Persistence.RepositoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Persistence.DependencyResolvers
{
 
    public static class RepositoryResolver
    {
        public static void AddRepositoryService(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>)); //Eger BaseRepository class'ınız abstract degilse ve generic ise ve bununla birlikte onu middleware servislerine eklemek istiyorsanız bu ifadeyi kullanırsınız...


            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IBookTagRepository, BookTagRepository>();


        }
    }
}
