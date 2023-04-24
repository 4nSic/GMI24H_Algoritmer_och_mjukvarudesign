using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public interface IHashTable
    {
        public void Add(string key, object value);
        public object Get(string key);
        public void Remove(string key);
    }
}
