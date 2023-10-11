using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalDocsData.Repositoriy
{
    public interface IRepositoriy<T> where T: class // _ замена имени переменной на имя файла или что-то
    {
        // CRUD методы
        public void Add(T item);
        public void Update(T item);
        public void Delete(int Id);
        public T GetId(int id); //  с маленькой параметры метода
        public IEnumerable<T> GetName(string  name);
        public IEnumerable<T> GetAll();
        public int Save();
    }
}
