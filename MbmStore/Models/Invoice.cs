using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;
        public int InvoiceId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice {     
            get {
                decimal totalPrice = 0;
                foreach(OrderItem orderItem in OrderItems)
                {
                    totalPrice += orderItem.TotalPrice * orderItem.Quantity;
                }
                return totalPrice;
            } 
        }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();// auto property wityhout the private field
        public int CustomerId { get; internal set; }

        public Invoice() { }
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
           
        }
        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}
