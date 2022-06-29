// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;

Prodotto mioProdotto = new Prodotto();
Console.WriteLine(mioProdotto.GetCode());

mioProdotto.Name ="lavatrice";
Console.WriteLine(mioProdotto.Name);

mioProdotto.Price = 20;
Console.WriteLine(mioProdotto.Price);

Console.WriteLine(mioProdotto.TaxedPrice(20));

Console.WriteLine(mioProdotto.FullName());





//int newCode = new Random().Next(1,100000000);
//string str = newCode.ToString();
//string result =str.PadLeft(8, '0');
//Console.WriteLine(result);

