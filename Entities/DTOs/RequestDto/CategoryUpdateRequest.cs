using CorePackages.Entities;

namespace Entities.DTOs.RequestDto;

public record CategoryUpdateRequest(int CategoryId, string CategoryName) : IDto
{
}
