using CorePackages.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfBookDal : EfEntityRepositoryBase<Book, BookLibraryContext>, IBookDal
{
    public List<BookDetailDto> GetBookDetails()
    {
        using(BookLibraryContext context = new BookLibraryContext())
        {
            var result = from b in context.Books
                         join c in context.Categories
                         on b.CategoryId equals c.CategoryId
                         join a in context.Authors
                         on b.AuthorId equals a.AuthorId
                         join p in context.Publishers
                         on b.PublisherId equals p.PublisherId
                         select new BookDetailDto
                         {
                             BookId = b.BookId,
                             BookName = b.BookName,
                             CategoryName = c.CategoryName,
                             PublisherName = p.PublisherName,
                             AuthorName = a.AuthorName,
                             Price = b.Price
                         };
            return result.ToList();
        }
    }
}
