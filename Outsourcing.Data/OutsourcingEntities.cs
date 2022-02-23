using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using Outsourcing.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Outsourcing.Data
{
    public class OutsourcingEntities : IdentityDbContext<AccountUser>
    {

        public OutsourcingEntities()
            : base("OutsourcingEntities")
        {
        }
        //public DbSet<ProductRelationship> ProductRelationships { get; set; }
        public DbSet<DocumentCategory> DocumentCategorys { get; set; }
        public DbSet<DocumentStore> DocumentStore { get; set; }
        public DbSet<TransferLog> TransferLogs { get; set; }
        public DbSet<WebsiteAttribute> WebsiteAttributes { get; set; }
        //public DbSet<AccountUser> AccountUsers { get; set; }


        public virtual void Commit()
        {
            try
            {
                
                base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

        }


        





 
    }
}