using Dokumenty.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenty.Repository
{
    public class ProcessOrderRepository
    {
        private readonly List<ProcessOrdery> _processordery = new();

        public void Add(ProcessOrdery processOrdery)
        {
          //  _processordery.Add(processOrdery);

            processOrdery.Id= _processordery.Count + 1;
            _processordery.Add(processOrdery);
        }

        public void Save()
        {
            foreach(var processOrdery in _processordery)
            {
                Console.WriteLine(processOrdery);
            }
        }
        public ProcessOrdery GetById(int id) 
        {
            return _processordery.Single(item => item.Id == id);
        }

    }
}
