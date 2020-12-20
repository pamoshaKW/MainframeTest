using Mainframe.Test.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data
{
    public class DatabaseContext: DbContext
    {
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
       public DbSet<Students> Students { get; set; }
       public DbSet<Subjects> Subjects { get; set; }
    }
}
