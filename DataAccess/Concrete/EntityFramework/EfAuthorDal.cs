using CorePackages.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfAuthorDal : EfEntityRepositoryBase<Author, BookLibraryContext>, IAuthorDal
{
}
