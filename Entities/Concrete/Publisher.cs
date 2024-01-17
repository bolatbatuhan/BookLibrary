using CorePackages.Entities;
using Entities.DTOs.RequestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Publisher : IEntity
{
    public int PublisherId { get; set; }
    public string PublisherName { get; set; }
    public List<Book> Books { get; set; }

    public static implicit operator Publisher(PublisherAddRequest publisherAddRequest) =>
        new Publisher
        {
            PublisherName = publisherAddRequest.PublisherName,
        };
    public static implicit operator Publisher(PublisherUpdateRequest publisherUpdateRequest) =>
        new Publisher
        {
            PublisherId = publisherUpdateRequest.PublisherId,
            PublisherName = publisherUpdateRequest.PublisherName,
        };
}
