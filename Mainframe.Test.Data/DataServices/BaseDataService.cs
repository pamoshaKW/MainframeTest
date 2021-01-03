using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Data_Services
{
    public interface IBaseDataService
    {
        //IStudentDataService Student { get; }
        //ISubjectDataService Subject { get; }

        //IStudentSubjectDataService StudentSubject { get; }

        void SaveChanges();
    }

    public class BaseDataService : IBaseDataService
    {
        private DatabaseContext databaseContext;
        public BaseDataService(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        //public IStudentDataService Student => throw new NotImplementedException();

        //public ISubjectDataService Subject => throw new NotImplementedException();

        //public IStudentSubjectDataService StudentSubject => throw new NotImplementedException();

        public void SaveChanges()
        {
            this.databaseContext.SaveChanges();
        }


    }
}
