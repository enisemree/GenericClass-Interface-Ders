using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass.Interfaces
{
    //Interface sadece fonksiyon isimlerini tutar... Bi nevi template
    // Newlenemez!!!! Fonksiyonun içini yazamazsın sadece ismini oluşturabilirsin...
    public interface IDBIslemleri<T> where T : class
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        T Get(int id);
        List<T> GetAll();
    }
}
