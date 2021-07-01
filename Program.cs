using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database are you looking for? List, SQL, or Mongo");
            var userInput = Console.ReadLine();

            IDataAccess da = DataAccessFactory.GetDataAccess(userInput);

            List<Product> products = da.LoadData();
            da.SaveData();

            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " +
                    $"Product Price: {product.Price,0:c}");
            }

        }
    }
}
