using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lectus.Services.MasterServices
{
    public interface IMasterService<T>
    {
        ICollection<T> GetAllMasterData();
        ICollection<T> FindBy(Expression<Func<T, bool>> predicate);
        T AddMaster(T entity);
        T DeleteMaster(T entity);
        void EditMaster(T entity);
    }
}
