namespace ADVC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // handle products, orders, notifications, and reports. 


            List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
    new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
    new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
    new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
    new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
    new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
    new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
    new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
    new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
    new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
};
            #region Task 01
            static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
            {
                List<Product> res = new List<Product>();


                foreach (Product product in products)
                {

                    if (filter(product))
                    {
                        res.Add(product);
                    }
                }
                return res;
            }


            List<Product> elec = SearchProducts(products, product => product.Category == "Electronics");
            List<Product> price = SearchProducts(products, product => product.Price < 50);
            List<Product> stock = SearchProducts(products, product => product.Stock > 0);
            List<Product> Category = SearchProducts(products, product => product.Category == "Clothing" && product.Price < 100);



            //       Console.WriteLine("--- Electronics ---");

            //       foreach (Product product in elec)
            //       {
            //           Console.WriteLine(
            //$"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //       }


            //       Console.WriteLine("--- Under $50 ---");

            //       foreach (Product product in price)
            //       {
            //           Console.WriteLine(
            //               $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //       }

            //       Console.WriteLine("--- In Stock ---");

            //       foreach (Product product in stock)
            //       {
            //           Console.WriteLine(
            //               $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //       }


            //       Console.WriteLine("--- Clothing Under $100 ---");

            //       foreach (Product product in Category)
            //       {
            //           Console.WriteLine(
            //               $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //       }
            #endregion

            #region Task 03 3.1  Print Reports 
            //static void PrintReport(List<Product> products, Action<Product> action)
            //{
            //    foreach (Product product in products)
            //    {
            //        action(product);
            //    }
            //}

            //Console.WriteLine("--- Short Report ---");

            //PrintReport(products, product => { Console.WriteLine($"{product.Name} - ${product.Price}"); });

            //Console.WriteLine("--- Detailed Report ---");

            //PrintReport(products, product =>
            //{
            //    Console.WriteLine(
            //        $"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}"
            //    );
            //});

            #endregion

            #region Task 03 3.2. Transform Products 

            //static List<string> TransformProducts(List<Product> products, Func<Product, string> function)
            //{
            //    List<string> res = new List<string>();

            //    foreach (Product product in products)
            //    {
            //        res.Add(function(product));
            //    }
            //    return res;


            //}

            //List<string> priceLabel = TransformProducts(products, product => product.Price > 100 ? "Expensive!" : "Affordable");


            //Console.WriteLine("\n--- Summary List ---");

            //List<string> summary = TransformProducts(products, product => $"{product.Name} (${product.Price})");

            //foreach (string item in summary)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("--- Price Labels ---");

            //for (int i = 0; i < products.Count; i++)
            //{
            //    Console.WriteLine($"{products[i].Name}: {priceLabel[i]}");
            //}
            #endregion


            #region Task 03 3.3. Filter Products 


            static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
            {
                List<Product> res = new List<Product>();

                foreach (Product product in products)
                {

                    if (condition(product))
                    {

                        res.Add(product);
                    }


                }
                return res;

            }
            List<Product> lowStock = FilterProducts(products, product => product.Stock < 20);
            Console.WriteLine("\n--- Low-Stock Alert ---");


            foreach (Product prod in lowStock)
            {
                Console.WriteLine($"[LOW STOCK] {prod.Name}: only {prod.Stock} left!");
            }

            #endregion

        }


    }
}
