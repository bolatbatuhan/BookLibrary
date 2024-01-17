using CorePackages.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Abstract;

public interface ICategoryService
{

    IDataResult<List<Category>> GetAll();
    IDataResult<CategoryResponseDto> GetById(int categoryId);
    IResult Add(CategoryAddRequest categoryAddRequest);
    IResult Delete(int categoryId);
    IResult Update(CategoryUpdateRequest categoryUpdateRequest);

}
