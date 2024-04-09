// See https://aka.ms/new-console-template for more information
using Dokumenty.Entity;
using Dokumenty.Repository;



var processOrderRpository = new ProcessOrderRepository();
processOrderRpository.Add(new ProcessOrdery { PO = 123456789 });
processOrderRpository.Add(new ProcessOrdery { PO = 234567890 });
processOrderRpository.Add(new ProcessOrdery { PO = 345678901 });

processOrderRpository.Save();
