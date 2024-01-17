using CorePackages.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Abstract;

public interface IAuthorService
{

    IDataResult<List<Author>> GetAll();
    IDataResult<AuthorResponseDto> GetById(int authorId);
    IResult Add(AuthorAddRequest authorAddRequest);
    IResult Delete(int authorId);
    IResult Update(AuthorUpdateRequest authorUpdateRequest);

}
