using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outsourcing.Core.Common;
using Outsourcing.Data.Models;
using Outsourcing.Data.Infrastructure;
using Outsourcing.Data.Repository;
using Outsourcing.Service.Properties;


namespace Outsourcing.Service
{
    public interface IDocumentStoreService
    {

        IEnumerable<DocumentStore> GetProductCategories();
        IEnumerable<DocumentStore> GetProductCategoriesHome();
        DocumentStore GetDocumentStoreById(int DocumentStoreId);
        void CreateDocumentStore(DocumentStore DocumentStore);
        void EditDocumentStore(DocumentStore DocumentStoreToEdit);
        void DeleteProductCategories(int DocumentStoreId);
        void SaveDocumentStore();
        IEnumerable<ValidationResult> CanAddDocumentStore(DocumentStore DocumentStore);

    }
    class DocumentStoreService : IDocumentStoreService
    {
        #region Field
        private readonly IDocumentStoreRepository DocumentStoreRepository;
        private readonly IUnitOfWork unitOfWork;
        #endregion

        #region Ctor
        public DocumentStoreService(IDocumentStoreRepository DocumentStoreRepository, IUnitOfWork unitOfWork)
        {
            this.DocumentStoreRepository = DocumentStoreRepository;
            this.unitOfWork = unitOfWork;
        }
        #endregion

        #region BaseMethod

        public IEnumerable<DocumentStore> GetProductCategories()
        {
            var DocumentStores = DocumentStoreRepository.GetAll().Where(p => p.isDelete == false && p.Id != 7);
            return DocumentStores;
        }

        public DocumentStore GetDocumentStoreById(int DocumentStoreId)
        {
            var DocumentStore = DocumentStoreRepository.GetById(DocumentStoreId);
            return DocumentStore;
        }

        public void CreateDocumentStore(DocumentStore DocumentStore)
        {
            DocumentStoreRepository.Add(DocumentStore);
            SaveDocumentStore();
        }

        public void EditDocumentStore(DocumentStore DocumentStoreToEdit)
        {
            DocumentStoreRepository.Update(DocumentStoreToEdit);
            SaveDocumentStore();
        }

        public void DeleteProductCategories(int DocumentStoreId)
        {
            //Get DocumentStore by id.
            var DocumentStore = DocumentStoreRepository.GetById(DocumentStoreId);
            if (DocumentStore != null)
            {
                DocumentStoreRepository.Delete(DocumentStore);
                SaveDocumentStore();
            }
        }

        public void SaveDocumentStore()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<ValidationResult> CanAddDocumentStore(DocumentStore DocumentStore)
        {

            //    yield return new ValidationResult("DocumentStore", "ErrorString");
            return null;
        }

        public IEnumerable<DocumentStore> GetProductCategoriesHome()
        {
            var DocumentStores = DocumentStoreRepository.GetAll();
            return DocumentStores;
        }

        #endregion
    }
}
