using CorePackages.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs;

public class BookDetailDto : IDto
{
    public int BookId { get; set; }
    public string BookName { get; set; }
    public string PublisherName { get; set; }
    public string CategoryName { get; set; }
    public string AuthorName { get; set; }
    public double Price { get; set; }
}
