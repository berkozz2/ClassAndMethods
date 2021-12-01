using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    //Bir class'ın sonunda Manager görürseniz bunlar bir operasyon tutuyor demektir.
    //Eğer bir yerde normal bir parantez görürseniz anlayın ki orada bir metod çalışıyor.
    public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " : " + "Tebrikler. Sepete Eklendi.");
        }

        public void Add2(string productName, string productDescription, double price ) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productName); 
        }
    }
}
