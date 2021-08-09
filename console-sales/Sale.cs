using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_sales
{
    public class Sale
    {
        public Sale(string sellerName, string customerName, DateTime dateSale, string saleItemName, decimal saleValue)
        {
            SellerName = sellerName;
            CustomerName = customerName;
            DateSale = dateSale;
            SaleItemName = saleItemName;
            SaleValue = saleValue;
        }

        public string SellerName { get; }
        public string CustomerName { get; }
        public DateTime DateSale { get; }
        public string SaleItemName { get; }
        public decimal SaleValue { get; }

        public override string ToString()
        {
            return $"Seller={SellerName};Customer={CustomerName};Date={DateSale.ToShortDateString()};Item={SaleItemName};Value={SaleValue};";
        }
    }
}
