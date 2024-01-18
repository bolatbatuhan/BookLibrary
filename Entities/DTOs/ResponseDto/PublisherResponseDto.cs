using Entities.Concrete;

namespace Entities.DTOs.ResponseDto;

public record  PublisherResponseDto(int PublisherId, string PublisherName)
{
    public static implicit operator PublisherResponseDto(Publisher publisher)
    {
        return new PublisherResponseDto
            (
            PublisherId: publisher.PublisherId,
            PublisherName: publisher.PublisherName
            );
        
    }
}
