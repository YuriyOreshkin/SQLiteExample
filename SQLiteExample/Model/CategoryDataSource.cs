using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteExample.UI.Model
{
    public class CategoryDataSource : BindingSource
    {
        private ICollection<Category> list;

        public CategoryDataSource()
        {
            try
            {
                IRepository repository = new EFRepository();
                list = repository.categories.Get().ToList();
            }
            catch (Exception e)
            {
                list = new List<Category>();
            }
            this.DataSource = list;
        }

        public CategoryDataSource(IEnumerable<Category> data)
        {
            list = data.ToList();
            this.DataSource = list;
        }
    }
    
}
