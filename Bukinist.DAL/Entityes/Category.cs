using Bukinist.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukinist.DAL.Entityes
{
    public class Category : NamedEntity
    {
        public virtual ICollection<Book> Books { get; set; }
    }
}
