using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record PublisherAddRequest(string PublisherName) : IDto
{
}
