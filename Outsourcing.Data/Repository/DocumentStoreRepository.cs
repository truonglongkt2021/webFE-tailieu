using Outsourcing.Data.Infrastructure;
using Outsourcing.Data.Models;
using System;
using System.Linq.Expressions;

namespace Outsourcing.Data.Repository
{

    public class DocumentStoreRepository : RepositoryBase<DocumentStore>, IDocumentStoreRepository
    {
        public DocumentStoreRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IDocumentStoreRepository : IRepository<DocumentStore>
    {

    }
}
