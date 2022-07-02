using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        //int id;
        //string name;
        //string description;
        //int price;
        //int iva;

        public Prodotto(string name, string description, int price, int iva)
        {
            this.Id = new Random().Next(1, 100000000);
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Iva = iva;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Iva { get; set; }

        public void PrintProduct()
        {
            Console.WriteLine("Nome prodotto: {0}", this.FullName());
            Console.WriteLine("Descrizione: {0}", this.Description);
            Console.WriteLine("Prezzo: {0}$", this.Price);
            Console.WriteLine("Prezzo tassato: {0}$", this.TaxedPrice());
        }
        public int TaxedPrice()
        {
            return this.Price += this.Price * this.Iva / 100;
        }

        public string FullName()
        {
            return this.Name + "-" + this.Id.ToString().PadLeft(8, '0');

        }
    }
}
