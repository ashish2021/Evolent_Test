using Evolent.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Evolent.Data.Configuration
{
    public class ContactConfiguration : EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            ToTable("Contacts");
            Property(g => g.FirstName).IsRequired().HasMaxLength(50);
            Property(g => g.Email).IsRequired();
        }
    }
}
