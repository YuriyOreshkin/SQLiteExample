using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample.UI.Model
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get();
        BindingList<TEntity> ToBindingList();
        void Create(TEntity item);
        void Delete(TEntity item);
        void Update(TEntity item);

    }

    
}
