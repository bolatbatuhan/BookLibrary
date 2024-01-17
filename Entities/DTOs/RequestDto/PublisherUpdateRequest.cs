using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record PublisherUpdateRequest(int PublisherId, string PublisherName) : IDto
{
}
