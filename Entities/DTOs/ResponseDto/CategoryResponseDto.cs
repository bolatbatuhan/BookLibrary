using CorePackages.Entities;
using Entities.Concrete;

namespace Entities.DTOs.ResponseDto;

public record CategoryResponseDto(int CategoryId, string CategoryName) : IDto
{
    public static implicit operator CategoryResponseDto(Category category)
    {
        return new CategoryResponseDto
            (
            CategoryId: category.CategoryId,
            CategoryName: category.CategoryName
            );
     
    }
        
       
}
