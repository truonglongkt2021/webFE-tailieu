using Outsourcing.Data.Infrastructure;
using Outsourcing.Data.Models;
using System;
using System.Linq.Expressions;

namespace Outsourcing.Data.Repository
{
 
    public class DocumentCategoryRepository : RepositoryBase<DocumentCategory>, IDocumentCategoryRepository
    {
        public DocumentCategoryRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IDocumentCategoryRepository : IRepository<DocumentCategory>
    {

    }
}
