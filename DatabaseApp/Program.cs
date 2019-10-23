using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//might aswell add this reference as well.
using Database;

namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //query and product and display it
            Console.WriteLine(DB.GetProduct(1));
            //create a product
            DB.CreateProduct("a cool product","12345");
            //create a customer
            DB.CreateCustomer("John","Doe");
            //create a sale
            DB.CreateSale(default,1,1);
            //update a customer
            DB.UpdateCustomer(1, "Brendan", "Wood");
            //show a list of sales
            Console.WriteLine(DB.GetSales());
            //delete a product
            DB.DeleteProduct(1);

        }


    }
}
