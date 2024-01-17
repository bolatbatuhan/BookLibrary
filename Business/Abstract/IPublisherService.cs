using CorePackages.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Abstract;

public interface IPublisherService
{

    IDataResult<List<Publisher>> GetAll();
    IDataResult<PublisherResponseDto> GetById(int publisherId);
    IResult Add(PublisherAddRequest publisherAddRequest);
    IResult Delete(int publisherId);
    IResult Update(PublisherUpdateRequest publisherUpdateRequest);

}
