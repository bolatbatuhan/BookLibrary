using CorePackages.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfPublisherDal : EfEntityRepositoryBase<Publisher, BookLibraryContext>, IPublisherDal
{
}
