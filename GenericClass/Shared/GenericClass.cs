using GenericClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass.Shared
{
    public class GenericClass<T> : IDBIslemleri<T> where T : class
    {
        public void Add(T entity)
        {
            var x = typeof(T);
            Console.WriteLine(x.Name + " için ekleme işlemi yapılıyor...");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
