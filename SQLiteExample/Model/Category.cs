using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; 



namespace SQLiteExample.UI.Model
{
    public class Category
    {
        public long id { get; set; }
        [DisplayName("Код")]
        public int code { get; set; }
        [DisplayName("Наименование")]
        public string name { get; set; }
    }
}
