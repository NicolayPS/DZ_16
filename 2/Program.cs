using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach(Product e in products)
            {
                if (e.Price > maxProduct.Price)
                {
                    maxProduct = e;
                }
            }
            Console.WriteLine($"Номер продукта- {maxProduct.Code} \nНазвание продукта- {maxProduct.Name} \nЦена продукта- {maxProduct.Price} р/кг");
            Console.ReadKey();
        }
    }
}
