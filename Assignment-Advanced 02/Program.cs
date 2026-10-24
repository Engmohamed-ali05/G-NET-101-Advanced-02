namespace Assignment_Advanced_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
            // started code
            class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
        }

         class Program
        {
            static List<Product> catalog = new List<Product>
    {
        new Product { Id = 1, Name = "laptop", Category = "electronics", Price = 1200, Stock = 10 },
        new Product { Id = 2, Name = "phone", Category = "electronics", Price = 800, Stock = 25 },
        new Product { Id = 3, Name = "t--shirt", Category = "clothing", Price = 30, Stock = 100 },
        new Product { Id = 4, Name = "jeans", Category = "clothing", Price = 60, Stock = 50 },
        new Product { Id = 5, Name = "chocolate", Category = "food", Price = 5, Stock = 200 },
        new Product { Id = 6, Name = "coffee Beans", Category = "food   ", Price = 15, Stock = 80 },
        new Product { Id = 7, Name = "C# Book", Category = "books", Price = 45, Stock = 30 },
        new Product { Id = 8, Name = "novel", Category = "books", Price = 20, Stock = 60 },
        new Product { Id = 9, Name = "  headphones", Category = "electronics", Price = 150, Stock = 40 },
        new Product { Id = 10, Name = "jacket", Category = "clothing", Price = 90, Stock = 15 }
        };


            static List<Product> SearchProducts(
                List<Product>  products,
                Func<Product, bool>   Filter)
            {
                List<Product> result = new List<Product>();

                foreach (Product p in products)
                {
                    if (Filter(p))
                        result.Add(p);
                }

                return result;
            }

            static void PrintProducts(string title, List<Product> products)
            {
                Console.WriteLine(".... " + title + "....");

                foreach (Product p in products)
                {
                    Console.WriteLine($"{p.Name} - ${p.Price} (stock: {p.Stock})");
                }

                Console.WriteLine();
            }

            static void Main(string[] args)
            {

                var electronics = SearchProducts(
                    catalog, p => p.Category == "electronics");

                PrintProducts("electronics", electronics);

                var under50 = SearchProducts(
                    catalog, p => p.Price < 50);

                PrintProducts("under $50", under50);

                var inStock = SearchProducts(
                    catalog, p => p.Stock > 0);
                PrintProducts("InStock", inStock);

                var clothing = SearchProducts(
                    catalog,
                    p => p.Category == "clothing" && p.Price < 100);

                PrintProducts("ClothingUnder $100", clothing);
            }
        }






            */


            #endregion

            #region Q2
            /*

              //Task 01 — Smart Product Search

              class Product
          {
              public int Id { get; set; }
              public string Name { get; set; }
              public string Category { get; set; }
              public double Price { get; set; }
              public int Stock { get; set; }
          }

          class Program
          {
              static List<Product> catalog = new List<Product>
  {
      new Product { Id = 1, Name = "laptop", Category = "electronics", Price = 1200, Stock = 10 },
      new Product { Id = 2, Name = "phone", Category = "electronics", Price = 800, Stock = 25 },
      new Product { Id = 3, Name = "t--shirt", Category = "clothing", Price = 30, Stock = 100 },
      new Product { Id = 4, Name = "jeans", Category = "clothing", Price = 60, Stock = 50 },
      new Product { Id = 5, Name = "chocolate", Category = "food", Price = 5, Stock = 200 },
      new Product { Id = 6, Name = "coffee Beans", Category = "food   ", Price = 15, Stock = 80 },
      new Product { Id = 7, Name = "C# Book", Category = "books", Price = 45, Stock = 30 },
      new Product { Id = 8, Name = "novel", Category = "books", Price = 20, Stock = 60 },
      new Product { Id = 9, Name = "  headphones", Category = "electronics", Price = 150, Stock = 40 },
      new Product { Id = 10, Name = "jacket", Category = "clothing", Price = 90, Stock = 15 }
      };



              static List<Product> SearchProducts(
                  List<Product> products,
                  Func<Product, bool> filter)
              {
                  List<Product> result = new List<Product>();

                  foreach (Product p in products)
                  {
                      if (filter(p))
                          result.Add(p);
                  }

                  return result;
              }

              static void PrintProducts(string title, List<Product> products)
              {
                  Console.WriteLine("... " + title + " ....");

                  foreach (Product p in products)
                  {
                      Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
                  }

                  Console.WriteLine();
              }

              static void Main(string[] args)
              {

                  var electronics = SearchProducts(
                      catalog, p => p.Category == "Electronics");

                  PrintProducts("Electronics", electronics);


                  var under50 = SearchProducts(
                      catalog, p => p.Price < 50);

                  PrintProducts("under$50", under50);


                  var inStock = SearchProducts(
                      catalog, p => p.Stock > 0);

                  PrintProducts("InStock", inStock);


                  var clothing = SearchProducts(
                      catalog,
                      p => p.Category == "Clothing" && p.Price < 100);

                  PrintProducts("ClothingUnder $100", clothing);
              }
          }




              */

            #endregion

            #region Q3
            //Task 03.1 — Print Reports

            class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
        }
        class Program
        {
            static List<Product> catalog = new List<Product>
{
    new Product { Id = 1, Name = "laptop", Category = "electronics", Price = 1200, Stock = 10 },
    new Product { Id = 2, Name = "phone", Category = "electronics", Price = 800, Stock = 25 },
    new Product { Id = 3, Name = "t--shirt", Category = "clothing", Price = 30, Stock = 100 },
    new Product { Id = 4, Name = "jeans", Category = "clothing", Price = 60, Stock = 50 },
    new Product { Id = 5, Name = "chocolate", Category = "food", Price = 5, Stock = 200 },
    new Product { Id = 6, Name = "coffee Beans", Category = "food   ", Price = 15, Stock = 80 },
    new Product { Id = 7, Name = "C# Book", Category = "books", Price = 45, Stock = 30 },
    new Product { Id = 8, Name = "novel", Category = "books", Price = 20, Stock = 60 },
    new Product { Id = 9, Name = "  headphones", Category = "electronics", Price = 150, Stock = 40 },
    new Product { Id = 10, Name = "jacket", Category = "clothing", Price = 90, Stock = 15 }
    };



            static void PrintReport(List<Product> products, Action<Product> action)
            {
                foreach (Product p in products)
                {
                    action(p);
                }
            }

            static void Main(string[] args)
            {
               
                Console.WriteLine("___ Short Report ____");

                PrintReport(catalog, p =>
                {
                    Console.WriteLine($"{p.Name} - ${p.Price}");
                });

                Console.WriteLine();

                
                Console.WriteLine("... Detailed Report ....");

                PrintReport(catalog, p =>
                {
                    Console.WriteLine(
                        $"{p.Category} | {p.Name} | price: ${p.Price} | stock: {p.Stock}");
                });
            }
        }












            #endregion





    }
}
}
