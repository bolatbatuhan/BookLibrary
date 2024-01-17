using CorePackages.Entities;
using Entities.DTOs.RequestDto;

namespace Entities.Concrete;

public class Author : IEntity
{
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }

    public List<Book> Books { get; set; }

    public static implicit operator Author(AuthorAddRequest authorAddRequest) =>
        new Author
        {
            AuthorName = authorAddRequest.AuthorName,
        };
    public static implicit operator Author(AuthorUpdateRequest authorUpdateRequest) =>
        new Author
        {
            AuthorId = authorUpdateRequest.AuthorId,
            AuthorName = authorUpdateRequest.AuthorName,
        };
}
