using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record CategoryAddRequest(string CategoryName) : IDto
{
}
