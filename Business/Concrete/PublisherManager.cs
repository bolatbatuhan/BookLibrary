using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using CorePackages.Aspects.Autofac.Validation;
using CorePackages.Utilities.Business;
using CorePackages.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Concrete;

public class PublisherManager : IPublisherService
{
    IPublisherDal _publisherDal;

    public PublisherManager(IPublisherDal publisherDal)
    {
        _publisherDal = publisherDal;
    }

    [ValidationAspect(typeof(PublisherValidator))]
    public IResult Add(PublisherAddRequest publisherAddRequest)
    {
        IResult result = BusinessRules.Run(CheckIfPublisherNameExits(publisherAddRequest.PublisherName));
        if(result != null)
        {
            return result;
        }

        _publisherDal.Add(publisherAddRequest);
        return new SuccessResult(Messages.PublisherAdded);
    }

    public IResult Delete(int publisherId)
    {
        Publisher publisher = _publisherDal.Get(p => p.PublisherId == publisherId);
        _publisherDal.Delete(publisher);
        return new SuccessResult(Messages.PublisherDeleted);
    }

    public IDataResult<List<Publisher>> GetAll()
    {
        return new SuccessDataResult<List<Publisher>>(_publisherDal.GetAll(),Messages.AllPublisherListed);
    }

    public IDataResult<PublisherResponseDto> GetById(int publisherId)
    {
        return new SuccessDataResult<PublisherResponseDto>(_publisherDal.Get(p=>p.PublisherId == publisherId));
    }

    [ValidationAspect(typeof(PublisherValidator))]
    public IResult Update(PublisherUpdateRequest publisherUpdateRequest)
    {
        _publisherDal.Update(publisherUpdateRequest);
        return new SuccessResult(Messages.PublisherUpdated);
    }
    private IResult CheckIfPublisherNameExits(string publisherName)
    {
        var result = _publisherDal.GetAll(p => p.PublisherName == publisherName).Any();
        if(result)
        {
            return new ErrorResult(Messages.PublisherNameIsAlreadyExits);
        }
        return new SuccessResult();
    }
}
