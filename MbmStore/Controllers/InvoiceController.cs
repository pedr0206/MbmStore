using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Infraestructure;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();
            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.FirstName + " " +
                invoice.Customer.LastName,
                    Value = invoice.Customer.CustomerId.ToString()
                });
            }
            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z =>
            z.Text).ToList<SelectListItem>();

            ViewData["Customers"] = customers;
            ViewBag.Invoices = Repository.Invoices;
            return View();
        }


        [HttpPost]
        public IActionResult Index(int? customer)
        {
            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();

            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                if (invoice.Customer.CustomerId == customer)
                {
                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName,
                        Value = invoice.Customer.CustomerId.ToString(),
                        Selected = true
                    });
                }
                else
                {
                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName,
                        Value = invoice.Customer.CustomerId.ToString()
                    });
                }
            }
            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z =>
            z.Text).ToList<SelectListItem>();

            if (customer != null)
            {
                // select invoices for a customer with linq
                List<Invoice> invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == customer).ToList();

                ViewBag.Invoices = invoices;
            }

            ViewData["Customers"] = customers;
            return View();
        }

    }
}