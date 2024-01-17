using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record AuthorAddRequest(string AuthorName) : IDto
{
}
