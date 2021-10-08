using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample.UI.Model
{
    public class Product
    {
        public long id { get; set; }
        [DisplayName("Наименование")]
        public string name { get; set; }
        [DisplayName("Дата")]
        public DateTime date { get; set; }
        [DisplayName("Цена")]
        public decimal price { get; set; }
        [DisplayName("Кол-во")]
        public int unitsinstock { get; set; }
        [DisplayName("Наличие")]
        public bool instock { get; set; }
      

        public long categoryid { get; set; }

        public virtual Category category { get; set; }

    }
}
