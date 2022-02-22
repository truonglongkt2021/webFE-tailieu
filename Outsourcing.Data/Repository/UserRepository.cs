using Outsourcing.Data.Infrastructure;
using Outsourcing.Data.Models;
using System;
using System.Linq.Expressions;
namespace Outsourcing.Data.Repository
{
    public class AccountUserRepository : RepositoryBase<AccountUser>, IAccountUserRepository
    {
        public AccountUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }        
        }
    public interface IAccountUserRepository : IRepository<AccountUser>
    {
        
    }
}