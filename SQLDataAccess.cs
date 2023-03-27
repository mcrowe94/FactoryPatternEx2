using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {

        }
        public List<Product> LoadData()
        {
            Console.WriteLine("Now loading data from your SQLDatabase...");
            return new List<Product>
            {
                new Product() {Name = "Book", Price = 8},
                new Product() {Name = "Toy Cars", Price = 5}

            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving your SQLDatabase...");
            Thread.Sleep(1000);
            Console.WriteLine("Thank you!");
        }
    }
}
