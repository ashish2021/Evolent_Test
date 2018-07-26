using Evolent.Data.Infrastructure;
using Evolent.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evolent.Data.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IContactRepository : IRepository<Contact>
    {

    }
}
