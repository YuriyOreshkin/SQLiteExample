using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample.UI.Model
{
    class StaticRepository : IRepository
    {

        private List<Category> _categories;
        private List<Product> _products;
        public StaticRepository()
        {
            _categories = new List<Category>()
            {
                                            new Category { id =1 , code=1, name="Напитки" },
                                            new Category { id =2 , code=2, name="Приправа" },
                                            new Category { id =3 , code=3, name="Кондитерские изделия" }
                                         };
            _products = new List<Product>()
            {
                new Product { id= 1, date=DateTime.Now, name="Чай", price=44.44M, unitsinstock=2, categoryid = 1,category = _categories.FirstOrDefault(c=>c.id == 1), instock = true   },
                new Product { id= 2, date=DateTime.Now, name="Кофе", price=500.12M, categoryid = 1, unitsinstock=0,category = _categories.FirstOrDefault(c=>c.id == 1), instock =false  },
                new Product { id= 3, date=DateTime.Now, name="Эклер", price=20.50M, categoryid = 3,  unitsinstock=5, category = _categories.FirstOrDefault(c=>c.id == 3),instock=true },
            };


        }

        public List<Category> categories()
        {
            return _categories;
        }

        public List<Product> products()
        {
            return _products;
        }
    }
        
}
