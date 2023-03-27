using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {

        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Now loading data from your ListDatabase...");
            return new List<Product>
            {
                new Product() {Name = "Windows Laptop", Price = 800},
                new Product() {Name = "iPhone 14 Plus Max", Price = 1200}
            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving your ListDatabase...");
            Thread.Sleep(1000);
            Console.WriteLine("Thank you!");
        }
    }
}
