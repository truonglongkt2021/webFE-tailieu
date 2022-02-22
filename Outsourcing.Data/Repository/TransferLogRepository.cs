using Outsourcing.Data.Infrastructure;
using Outsourcing.Data.Models;
using System;
using System.Linq.Expressions;

namespace Outsourcing.Data.Repository
{
    public class TransferLogRepository : RepositoryBase<TransferLog>, ITransferLogRepository
    {
        public TransferLogRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface ITransferLogRepository : IRepository<TransferLog>
    {

    }
}
