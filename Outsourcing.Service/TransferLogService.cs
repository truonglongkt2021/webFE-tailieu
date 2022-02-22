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
 
    public interface ITransferLogService
    {

        IEnumerable<TransferLog> GetProductCategories();
        IEnumerable<TransferLog> GetProductCategoriesHome();
        TransferLog GetTransferLogById(int TransferLogId);
        void CreateTransferLog(TransferLog TransferLog);
        void EditTransferLog(TransferLog TransferLogToEdit);
        void DeleteProductCategories(int TransferLogId);
        void SaveTransferLog();
        IEnumerable<ValidationResult> CanAddTransferLog(TransferLog TransferLog);

    }
    class TransferLogService : ITransferLogService
    {
        #region Field
        private readonly ITransferLogRepository TransferLogRepository;
        private readonly IUnitOfWork unitOfWork;
        #endregion

        #region Ctor
        public TransferLogService(ITransferLogRepository TransferLogRepository, IUnitOfWork unitOfWork)
        {
            this.TransferLogRepository = TransferLogRepository;
            this.unitOfWork = unitOfWork;
        }
        #endregion

        #region BaseMethod

        public IEnumerable<TransferLog> GetProductCategories()
        {
            var TransferLogs = TransferLogRepository.GetAll().Where(p => p.isDelete == false && p.Id != 7);
            return TransferLogs;
        }

        public TransferLog GetTransferLogById(int TransferLogId)
        {
            var TransferLog = TransferLogRepository.GetById(TransferLogId);
            return TransferLog;
        }

        public void CreateTransferLog(TransferLog TransferLog)
        {
            TransferLogRepository.Add(TransferLog);
            SaveTransferLog();
        }

        public void EditTransferLog(TransferLog TransferLogToEdit)
        {
            TransferLogRepository.Update(TransferLogToEdit);
            SaveTransferLog();
        }

        public void DeleteProductCategories(int TransferLogId)
        {
            //Get TransferLog by id.
            var TransferLog = TransferLogRepository.GetById(TransferLogId);
            if (TransferLog != null)
            {
                TransferLogRepository.Delete(TransferLog);
                SaveTransferLog();
            }
        }

        public void SaveTransferLog()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<ValidationResult> CanAddTransferLog(TransferLog TransferLog)
        {

            //    yield return new ValidationResult("TransferLog", "ErrorString");
            return null;
        }

        public IEnumerable<TransferLog> GetProductCategoriesHome()
        {
            var TransferLogs = TransferLogRepository.GetAll();
            return TransferLogs;
        }

        #endregion
    }
}
