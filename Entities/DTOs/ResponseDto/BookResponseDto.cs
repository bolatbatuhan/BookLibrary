using CorePackages.Entities;
using Entities.Concrete;

namespace Entities.DTOs.ResponseDto;
public record   BookResponseDto(int BookId, string BookName, string Description, double Price, int CategoryId, int PublisherId, int AuthorId)  : IDto
{
    public static implicit operator BookResponseDto(Book book)
    {
        return new BookResponseDto(
            BookId: book.BookId,
            BookName: book.BookName,
            Description: book.Description,
            Price: book.Price,
            CategoryId: book.CategoryId,
            PublisherId: book.PublisherId,
            AuthorId: book.AuthorId
            );
    }
}
