using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{       //çıplak class kalmasın         //Concrete klasöründeki sınıflar bir veritabanı 
                                        //tablosuna karşılık gelir.
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
