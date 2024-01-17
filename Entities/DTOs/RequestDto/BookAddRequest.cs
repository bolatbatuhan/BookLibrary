using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record  BookAddRequest (string BookName, string Description, double Price, int CategoryId, int PublisherId, int AuthorId) : IDto
{
}
