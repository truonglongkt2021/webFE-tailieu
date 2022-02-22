using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outsourcing.Data.Models
{
    public class TransferLog:BaseEntity
    {
        public TransferLog()
        {
            //set default
            this.TotalDownload = 0;
            this.CreatedTime = DateTimeOffset.Now;
            this.LastUpdatedTime = DateTimeOffset.Now;
            this.DeletedTime = DateTimeOffset.Now;
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DocumentId { get; set; }
        public string OtpToken { get; set; }
        public string Status { get; set; }
        public DateTimeOffset TimeExpired { get; set; }
        public string RefId { get; set; }
        public int TotalDownload { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletdBy { get; set; }
        public bool isDelete { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset DeletedTime { get; set; }
    }
}
