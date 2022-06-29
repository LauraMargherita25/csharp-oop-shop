using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        int code;
        string name;
        string description;
        int price;
        int iva;

        public Prodotto()
        {
            this.code = code; 
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;
        }

        public string GetCode()
        {
            this.code = new Random().Next(1, 100000000);
            return this.code.ToString().PadLeft(9, '0');
             

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description 
        { 
            get { return description; }
            set { description = value; }
        }
        
        public int Price
        {
            get { return price; }   
            set { price = value; }
        }
        
        public int Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        public int TaxedPrice(int iva)
        {
            return this.price = price + price * iva / 100;
        }

        public string FullName()
        {
            return this.name + "-" + this.code;

        }
    }
}
