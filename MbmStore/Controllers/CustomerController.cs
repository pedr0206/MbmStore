using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> listOfCustomers = new List<Customer>
            {
                new Customer( 1,"Maria", "Silva", "Rua da Graça", "3000", "Porto", new DateTime(2009,02,22)),
                new Customer( 2,"Bruno", "Lage", "Estrada de Benfica", "2000", "Lisboa", new DateTime(1981,04,11))
            };


            //Customer customer1 = new Customer("Maria", "Silva", "Rua da Graça", "3000", "Porto");
            //Customer customer2 = new Customer("Bruno", "Lage", "Estrada de Benfica", "2000", "Lisboa");

            //ViewBag.Customer1 = customer1;
            //ViewBag.Customer2 = customer2;
            ViewBag.ListOfCustomers = listOfCustomers;
            return View();
        }
    }
}