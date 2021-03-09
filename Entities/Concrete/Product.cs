using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    //public=bu class'a diğer katmanlarda ulaşabilsin demek.
    //data access=ürünü ekler
    //business=ürünü kontrol eder.
    //console=ürünü göstericek. 
    //entities=bu 3katmanda entitiesi kullanıcak.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
         
    }

                    
    

    
}
