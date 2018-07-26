using Evolent.Data.Configuration;
using Evolent.Model.Models;
using System;
using System.Data.Entity;

namespace Evolent.Data
{
    public class ContactEntities : DbContext
    {
        public ContactEntities() : base("ContactEntities") { }

        public DbSet<Contact> Contacts { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContactConfiguration());

        }
    }
}
