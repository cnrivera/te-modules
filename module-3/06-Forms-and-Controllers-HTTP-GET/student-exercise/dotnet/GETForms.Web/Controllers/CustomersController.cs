using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAO customerDAO;

        public CustomersController(ICustomerDAO dao)
        {
            this.customerDAO = dao;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchResult(CustomerSearchModel customers)
        {
            /* Call the DAL and pass the values as a model back to the View */
            var customerList = customerDAO.SearchForCustomers(customers.Name, customers.SortType);
            return View(customerList);
        }
    }
}