using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Infraestructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;
        public IActionResult Index(string category, int page = 1)
        {

            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = Repository.Products
                .Where(p => category == null || p.Category == category)
            .OrderBy(p => p.ProductId)
            .Skip((page - 1) * PageSize)
            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    Repository.Products.Count() :
                    Repository.Products.Where(e =>
                    e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);


        }
    }
}