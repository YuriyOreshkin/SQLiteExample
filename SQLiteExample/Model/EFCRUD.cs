using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample.UI.Model
{
    public class EFCRUD<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        private DbContext _context;
        private DbSet<TEntity> _dbSet;

        public EFCRUD(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }


        //Get all data
        public virtual IQueryable<TEntity> Get()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        //Create item  
        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        //Delete item
        public virtual void Delete(TEntity item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        //Update item
        public virtual void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //ToBindingList  item  
        public virtual BindingList<TEntity> ToBindingList()
        {
            _dbSet.Load();
            return _dbSet.Local.ToBindingList<TEntity>();
         
        }

    }
}
