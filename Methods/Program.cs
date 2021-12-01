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

//Stock Adedini sonradan eklemiş bile olsak hatasız buna Encapsulation denir.******
SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);
sepetManager.Add(product2);

//Bu şekilde kod yazdık diyelim bu sefer yönetim bizden stok adedi eklemizi isterse bütün sayfaları değiştirmek gerekir.
//sepetManager.Add2("Armut", "Yeşil Armut", 12);
//sepetManager.Add2("Elma", "Yeşil Elma", 15);
//sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 16);




//Console.WriteLine(description);
