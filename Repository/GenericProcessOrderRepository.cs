using Dokumenty.Entites;
using Dokumenty.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenty.Repository
{
    public class GenericProcessOrderRepository<T> where T : IEntity
    {
        protected readonly List<T> _items = new();

        public void Add(T item)
        {
          //  _processordery.Add(processOrdery);

            item.Id= _items.Count + 1;
            _items.Add(item);
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Save()
        {
            foreach(var item in _items)
            {
                Console.WriteLine(item);
            }
        }
        

    }
}
