using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using CorePackages.Aspects.Autofac.Validation;
using CorePackages.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Concrete;

public class AuthorManager : IAuthorService
{
    IAuthorDal _authorDal;

    public AuthorManager(IAuthorDal authorDal)
    {
        _authorDal = authorDal;
    }

    [ValidationAspect(typeof(AuthorValidator))]
    public IResult Add(AuthorAddRequest authorAddRequest)
    {
        _authorDal.Add(authorAddRequest);
        return new SuccessResult(Messages.AuthorAdded);
    }

    public IResult Delete(int authorId)
    {
        Author author = _authorDal.Get(a=>a.AuthorId == authorId);
        _authorDal.Delete(author);
        return new SuccessResult(Messages.AuthorDeleted);
    }

    public IDataResult<List<Author>> GetAll()
    {
        return new SuccessDataResult<List<Author>>(_authorDal.GetAll(),Messages.AllAuthorsListed);
    }

    public IDataResult<AuthorResponseDto> GetById(int authorId)
    {
       return new SuccessDataResult<AuthorResponseDto>(_authorDal.Get(a=>a.AuthorId ==  authorId));
    }

    [ValidationAspect(typeof(AuthorValidator))]
    public IResult Update(AuthorUpdateRequest authorUpdateRequest)
    {
        _authorDal.Update(authorUpdateRequest);
        return new SuccessResult(Messages.AuthorUpdated);
    }
}
