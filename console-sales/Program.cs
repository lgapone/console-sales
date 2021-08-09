using System;
using System.Collections.Generic;
using System.Linq;

namespace console_sales
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> listSales = new();
            List<string> listSeller = new();

            string seller;
            DateTime dateSale;
            decimal valueSale;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Enter {i}° seller name:");
                seller = Console.ReadLine();

                if (listSeller.Contains(seller))
                {
                    Console.WriteLine("Seller alredy inputted!");
                    i--;
                    continue;
                }

                listSeller.Add(seller);
            }

            while (true)
            {
                Console.WriteLine("Enter seller name:");
                seller = Console.ReadLine();

                if (!listSeller.Contains(seller))
                {
                    Console.WriteLine("Invalid Seller");
                    continue;
                }

                Console.WriteLine("Enter customer name:");
                string customer = Console.ReadLine();

                Console.WriteLine("Enter date of sale:");
                string date = Console.ReadLine();
                dateSale = new();
                try
                {
                    dateSale = DateTime.Parse(date);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input date");
                    continue;
                }

                Console.WriteLine("Enter sale item name:");
                string item = Console.ReadLine();

                Console.WriteLine("Enter sale value:");
                string value = Console.ReadLine();
                try
                {
                    valueSale = decimal.Parse(value);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input value");
                    continue;
                }

                listSales.Add(new Sale(seller, customer, dateSale, item, valueSale));

                foreach (Sale sale in listSales.OrderByDescending(x => x.SaleValue).ToList()) {
                    Console.WriteLine(sale.ToString());
                }
            }
        }
    }
}
