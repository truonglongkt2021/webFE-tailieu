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
    public interface IDocumentCategoryService
    {

        IEnumerable<DocumentCategory> GetProductCategories();
        IEnumerable<DocumentCategory> GetProductCategoriesHome();
        DocumentCategory GetDocumentCategoryById(int DocumentCategoryId);
        void CreateDocumentCategory(DocumentCategory DocumentCategory);
        void EditDocumentCategory(DocumentCategory DocumentCategoryToEdit);
        void DeleteProductCategories(int DocumentCategoryId);
        void SaveDocumentCategory();
        IEnumerable<ValidationResult> CanAddDocumentCategory(DocumentCategory DocumentCategory);

    }
    class DocumentCategoryService :IDocumentCategoryService
    {
        #region Field
        private readonly IDocumentCategoryRepository DocumentCategoryRepository;
        private readonly IUnitOfWork unitOfWork;
        #endregion

        #region Ctor
        public DocumentCategoryService(IDocumentCategoryRepository DocumentCategoryRepository, IUnitOfWork unitOfWork)
        {
            this.DocumentCategoryRepository = DocumentCategoryRepository;
            this.unitOfWork = unitOfWork;
        }
        #endregion

        #region BaseMethod

        public IEnumerable<DocumentCategory> GetProductCategories()
        {
            var DocumentCategorys = DocumentCategoryRepository.GetAll().Where(p => p.isDelete == false && p.Id != 7);
            return DocumentCategorys;
        }

        public DocumentCategory GetDocumentCategoryById(int DocumentCategoryId)
        {
            var DocumentCategory = DocumentCategoryRepository.GetById(DocumentCategoryId);
            return DocumentCategory;
        }

        public void CreateDocumentCategory(DocumentCategory DocumentCategory)
        {
            DocumentCategoryRepository.Add(DocumentCategory);
            SaveDocumentCategory();
        }

        public void EditDocumentCategory(DocumentCategory DocumentCategoryToEdit)
        {
            DocumentCategoryRepository.Update(DocumentCategoryToEdit);
            SaveDocumentCategory();
        }

        public void DeleteProductCategories(int DocumentCategoryId)
        {
            //Get DocumentCategory by id.
            var DocumentCategory = DocumentCategoryRepository.GetById(DocumentCategoryId);
            if (DocumentCategory != null)
            {
                DocumentCategoryRepository.Delete(DocumentCategory);
                SaveDocumentCategory();
            }
        }

        public void SaveDocumentCategory()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<ValidationResult> CanAddDocumentCategory(DocumentCategory DocumentCategory)
        {

            //    yield return new ValidationResult("DocumentCategory", "ErrorString");
            return null;
        }

        public IEnumerable<DocumentCategory> GetProductCategoriesHome()
        {
            var DocumentCategorys = DocumentCategoryRepository.GetAll();
            return DocumentCategorys;
        }

        #endregion
    }
}
