using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Outsourcing.Data.Models
{
    public class DocumentStore:BaseEntity
    {
        public DocumentStore()
        {
            //set default
            this.CreatedTime = DateTimeOffset.Now;
            this.LastUpdatedTime = DateTimeOffset.Now;
            this.DeletedTime = DateTimeOffset.Now;
            isDelete = false;
            isHot = false;
        }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long FileSize { get; set; }
        public string FilePath { get; set; }
        public string DocumentId { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string Temp_1 { get; set; }
        public int ViewCount { get; set; }
        public int Position { get; set; }
        public bool isHot { get; set; }
        public int Status_Doc { get; set; }
        public string Temp_2 { get; set; }
        public string Temp_3 { get; set; }
        public string Temp_4 { get; set; }
        public string Temp_5 { get; set; }
        public string Temp_6 { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset DeletedTime { get; set; }
        public bool isDelete { get; set; }
        public int DocumentCategoryId { get; set; }


        [ForeignKey("DocumentCategoryId")]
        virtual public DocumentCategory DocumentCategory { get; set; }
    }
}
