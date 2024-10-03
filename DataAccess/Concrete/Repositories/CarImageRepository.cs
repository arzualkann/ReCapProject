using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.Repositories
{
    public class CarImageRepository : EfRepositoryBase<CarImage, int, BaseDbContext>, ICarImageRepository
    {
        public CarImageRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
