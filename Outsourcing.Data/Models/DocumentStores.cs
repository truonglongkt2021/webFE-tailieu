using System;

namespace Outsourcing.Data.Models
{
    public class DocumentStores:BaseEntity
    {
        public DocumentStores()
        {
            //set default
            this.CreatedTime = DateTimeOffset.Now;
            this.LastUpdatedTime = DateTimeOffset.Now;
            this.DeletedTime = DateTimeOffset.Now;
        }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long FileSize { get; set; }
        public string FilePath { get; set; }
        public string DocumentId { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset DeletedTime { get; set; }
    }
}
