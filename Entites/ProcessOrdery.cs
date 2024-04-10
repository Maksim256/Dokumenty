using Dokumenty.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenty.Entity
{
    public class ProcessOrdery : EntityBase

    {
       // public int Id { get; set; }
        public int PO { get; set; }
        public int Gcas { get; set; }
        public string Nazwa { get; set; }
        public string Batch { get; set; }
        public string Status { get; set; }

        /*  public ProcessOrdery(int PO)
          {

          }*/
        public override string ToString() => $"Id:{Id},PO: {PO}";
    }

   
}
