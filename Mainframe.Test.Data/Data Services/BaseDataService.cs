using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Data_Services
{
    public interface IBaseDataService
    {
        void SaveChanges();
    }
    public class BaseDataService : IBaseDataService
    {
        private DatabaseContext databaseContext;
        public BaseDataService(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void SaveChanges()
        {
            this.databaseContext.SaveChanges();
        }
    }
}
