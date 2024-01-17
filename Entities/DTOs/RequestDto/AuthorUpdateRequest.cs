using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record AuthorUpdateRequest(int AuthorId,string AuthorName) : IDto
{
}
