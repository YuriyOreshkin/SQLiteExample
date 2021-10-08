using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample.UI.Model
{
    class EFRepository : IRepository
    {
        private SQLiteContext db;

        public EFRepository()
        {
            db = new SQLiteContext();
        }

        public ICRUD<Category> categories => new EFCRUD<Category>(db);

        public ICRUD<Product> products => new EFCRUD<Product>(db);

    }
}
