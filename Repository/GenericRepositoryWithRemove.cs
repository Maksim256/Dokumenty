using Dokumenty.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenty.Repository
{
    public class GenericRepositoryWithRemove<T> : GenericProcessOrderRepository<T>
        where T : IEntity
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
