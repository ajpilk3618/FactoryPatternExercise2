using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class SQLDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving data to SQL Database . . .");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Loading your SQL Database . . .");

            return new List<Product>()
            {
                new Product() {Name = "product 1", Price = 2.59},
                new Product() {Name = "product 2", Price = 4.99 },
                new Product() {Name = "product 3", Price = 18.99}
            };
        }
    }
}
