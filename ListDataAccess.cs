using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess 
    {

        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "product 1", Price = 2.59},
            new Product() {Name = "product 2", Price = 4.99 },
            new Product() {Name = "product 3", Price = 18.99}
        };

        public void SaveData()
        {
            Console.WriteLine("Saving data to list . . .");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Loading your list . . .");
            return Products;
        }
    }
}
