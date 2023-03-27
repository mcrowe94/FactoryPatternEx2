using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {

        }
        public List<Product> LoadData()
        {
            Console.WriteLine("Now loading data from MongoDatabase!");
            return new List<Product>()
            {
                new Product() {Name = "Stuffed Animal", Price = 5},
                new Product() {Name = "Samsung 75in Curve TV", Price = 1500}
            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving your MongoDatabase...");
            Thread.Sleep(1000);
            Console.WriteLine("Thank you!");
        }
    }



}
