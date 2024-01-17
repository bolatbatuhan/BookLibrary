using CorePackages.Entities;
using Entities.DTOs.RequestDto;

namespace Entities.Concrete;

public class Book : IEntity
{
    public int BookId { get; set; }
    public string BookName { get; set; }
    public int AuthorId { get; set; }
    public int PublisherId { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Author Author { get; set; }
    public Publisher Publisher { get; set; }
    public Category Category { get; set; }

    public static implicit operator Book(BookAddRequest bookAddRequest) =>
         new Book
         {
             BookName = bookAddRequest.BookName,
             AuthorId = bookAddRequest.AuthorId,
             PublisherId = bookAddRequest.PublisherId,
             CategoryId = bookAddRequest.CategoryId,
             Description = bookAddRequest.Description,
             Price = bookAddRequest.Price,
         };
    public static implicit operator Book(BookUpdateRequest bookUpdateRequest) =>
        new Book
        {
            BookId = bookUpdateRequest.BookId,
            BookName = bookUpdateRequest.BookName,
            AuthorId = bookUpdateRequest.AuthorId,
            PublisherId = bookUpdateRequest.PublisherId,
            CategoryId = bookUpdateRequest.CategoryId,
            Description = bookUpdateRequest.Description,
            Price = bookUpdateRequest.Price,

        };
}
