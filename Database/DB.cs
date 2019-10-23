using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DB
    {
        private static Demo1Entities myDb = new Demo1Entities();
        public static IEnumerable<Product> GetProducts()
        {
            return myDb.Products.ToList();
        }

        //find a product based on ID
        public static Product GetProduct(int id)
        {
            if (myDb.Products.Find(id).ProductIsActive){
                return myDb.Products.Find(id);
            }
            else {
                return null;
            }
        }

        //create a product
        public static Product CreateProduct(String p_desc,String p_upc)
        {

            Product p = new Product();
            p.ProductDescription = p_desc;
            p.ProductUpc = p_upc;
            p.ProductIsActive = true;

            myDb.Products.Add(p);
            myDb.SaveChanges();

            return null;
        }

        //create a customer
        public static Customer CreateCustomer(String fname, String lname)
        {
            Customer c = new Customer();
            c.CustomerFirstName = fname;
            c.CustomerLastName = lname;

            myDb.Customers.Add(c);
            myDb.SaveChanges();

            return null;
        }

        //create a sale
        public static Sale CreateSale(DateTime sd, int p_id, int c_id)
        {
            Sale s = new Sale();
            s.SaleDate = sd;
            s.ProductId = p_id;
            s.CustomerId = c_id;

            myDb.Sales.Add(s);
            myDb.SaveChanges();

            return null;
        }

        //update a customer
        public static Customer UpdateCustomer(int id, String fname, String lname)
        {
            myDb.Customers.Find(id).CustomerFirstName = fname;
            myDb.Customers.Find(id).CustomerLastName = lname;

            myDb.SaveChanges();

            return null;
        }

        //show a list of sales
        public static IEnumerable<Sale> GetSales()
        {
            return myDb.Sales.ToList();
        }

        //delete a product
        public static Product DeleteProduct(int id)
        {
            myDb.Products.Find(id).ProductIsActive = false;
            myDb.SaveChanges();
            return null;
        }
    }
}
