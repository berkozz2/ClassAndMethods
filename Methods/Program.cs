using System;
using Methods;

Product product1 = new Product();
product1.Id = 1;
product1.ProductName = "Elma";
product1.Price = 15;
product1.ProductDescription = "Amasya Elması";

Product product2 = new Product();
product2.Id = 2;
product2.ProductName = "Karpuz";
product2.Price = 16;
product2.ProductDescription = "Diyarbakır Karpuzu";

Product[] products = new Product[] {product1, product2 };

foreach (var product in products)
{
    Console.WriteLine(product.ProductName + " " +  "Kilosu"  + " " +   product.Price + "TL");
    Console.WriteLine(product.ProductDescription);
    Console.WriteLine("-----------------------");
}

Console.WriteLine("-------------Methods---------------");

//Method bana tekrar tekrar kullanma imkanı verdi.

SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);
sepetManager.Add(product2);




//Console.WriteLine(description);
