using Ordering.Application.Common.Persistence;
using Ordering.Application.UseCases.Orders.Repositories;
using Ordering.Domain.Aggregates.OrderAggregate;
using Ordering.Domain.Common;
using Ordering.Write.Infrastructure.Repositories;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
    {
        private readonly IUnitOfWork? _unitOfWork;

        public OrderCommandRepository(IWriteDbContext dbContext) : base(dbContext)
        {
        }

        public IUnitOfWork UnitOfWork => _unitOfWork;

        //public OrderCommandRepository(IUnitOfWork? unitOfWork) 
        //{
        //    _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork));
        //}
    }
}
