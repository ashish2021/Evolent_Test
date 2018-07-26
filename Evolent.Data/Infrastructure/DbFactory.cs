using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolent.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ContactEntities dbContext;

        public ContactEntities Init()
        {
            return dbContext ?? (dbContext = new ContactEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
