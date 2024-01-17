using CorePackages.Entities;
using Entities.Concrete;

namespace Entities.DTOs.ResponseDto;

public record AuthorResponseDto(int AuthorId, string AuthorName) : IDto
{
    public static implicit operator AuthorResponseDto(Author author)
    {
        return new AuthorResponseDto
            (
                AuthorId : author.AuthorId,
                AuthorName : author.AuthorName
            );
    }
}
