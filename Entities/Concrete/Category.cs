using CorePackages.Entities;
using Entities.DTOs.RequestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Category : IEntity
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

    public List<Book> Books { get; set; }

    public static implicit operator Category(CategoryAddRequest categoryAddRequest) =>
        new Category
        {
            CategoryName = categoryAddRequest.CategoryName,
        };
    public static implicit operator Category(CategoryUpdateRequest categoryUpdateRequest) =>
        new Category
        {
            CategoryId = categoryUpdateRequest.CategoryId,
            CategoryName = categoryUpdateRequest.CategoryName,
        };
}
