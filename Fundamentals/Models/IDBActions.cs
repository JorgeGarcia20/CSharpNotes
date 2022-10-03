using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Models
{
    internal interface IDBActions<T>
    {
        public List<T> Get();
        public bool Add(T t);
        public bool Remove(int Id);
        public bool Update(T t, int Id);

    }
}
