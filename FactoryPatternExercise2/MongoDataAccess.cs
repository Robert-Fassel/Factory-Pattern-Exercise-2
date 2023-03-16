using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2 
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess() { }

        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Shoes", Price = 50},
            new Product() {Name = "Hat", Price = 10},
            new Product() {Name = "Shirt", Price = 20},
            new Product() {Name = "Pants", Price = 30},
        };
        
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo");
            return Products;
        }
        public void SaveData() 
        {
            Console.WriteLine("I am saving data from Mongo");
        }
    
    }
}
