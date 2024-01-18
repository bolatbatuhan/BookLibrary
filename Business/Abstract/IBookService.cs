using CorePackages.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Abstract;

public interface IBookService
{
    IDataResult<List<Book>> GetByPrice(double min, double max);
    IDataResult<List<BookResponseDto>> GetAll();
    IDataResult<BookResponseDto> GetById(int bookId);
    IDataResult<List<BookDetailDto>> GetDetail();
    IResult Add(BookAddRequest bookAddRequest);
    IResult Delete(int bookId);
    IResult Update(BookUpdateRequest bookUpdateRequest);
    
}
