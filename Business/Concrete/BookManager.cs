using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using CorePackages.Aspects.Autofac.Validation;
using CorePackages.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Concrete;

public class BookManager : IBookService
{
    IBookDal _bookDal;
    ICategoryService _categoryService;

    public BookManager(IBookDal bookDal, ICategoryService categoryService)
    {
        _bookDal = bookDal;
        _categoryService = categoryService;
    }

    [ValidationAspect(typeof(BookValidator))]
    public IResult Add(BookAddRequest bookAddRequest)
    {
        _bookDal.Add(bookAddRequest);
        return new SuccessResult(Messages.BookAdded);
    }

    public IResult Delete(int bookId)
    {
        Book book = _bookDal.Get(b=>b.BookId == bookId);
        _bookDal.Delete(book);
        return new SuccessResult(Messages.BookDeleted);
    }

    public IDataResult<List<BookResponseDto>> GetAll()
    {
        var books = _bookDal.GetAll();
        var bookResponseDto = books.Select(book => new BookResponseDto(
            book.BookId, book.BookName, book.Description,book.Price,book.AuthorId,book.CategoryId,book.PublisherId )).ToList();
            
        return new SuccessDataResult<List<BookResponseDto>>(bookResponseDto,Messages.AllBooksListed); 
    }

    public IDataResult<BookResponseDto> GetById(int bookId)
    {
        return new SuccessDataResult<BookResponseDto>(_bookDal.Get(b => b.BookId == bookId));
    }

    public IDataResult<List<Book>> GetByPrice(double min, double max)
    {
        return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.Price >= min && b.Price <= max));
    }

    public IDataResult<List<BookDetailDto>> GetDetail()
    {
        return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails());
    }

    [ValidationAspect(typeof(BookValidator))]
    public IResult Update(BookUpdateRequest bookUpdateRequest)
    {
        _bookDal.Update(bookUpdateRequest);
        return new SuccessResult(Messages.BookUpdated);
    }
    private IResult CheckIfBookNameExits(string bookName)
    {
        var result = _bookDal.GetAll(b=>b.BookName == bookName).Any();
        if (result)
        {
            return new ErrorResult(Messages.BookNameAlreadyExits);
        }
        return new SuccessResult();
    }
}
