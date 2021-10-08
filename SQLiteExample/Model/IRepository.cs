using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample.UI.Model
{
    public interface IRepository
    {
        ICRUD<Category> categories { get; }
        ICRUD<Product> products { get;  } 
      
    }
}
