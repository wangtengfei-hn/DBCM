using Example.MSSQL.Repository.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository
{
    public interface IMSSQLDbContext
    {
        Database Database { get; }

        #region DbSet

        DbSet<Member> Member { get; set; }

        #endregion


        bool Save();

        bool Save(out Exception exception);

        Task<bool> SaveAsync();
    }
}
