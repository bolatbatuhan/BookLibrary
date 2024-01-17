using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record BookUpdateRequest(int BookId,string BookName, string Description, double Price, int CategoryId, int PublisherId, int AuthorId) : IDto
{
}
