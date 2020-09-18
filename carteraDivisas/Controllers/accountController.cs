using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudPer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudPer.Controllers
{   
    public class accountController : Controller
    {
        private PersonaContext _context;
        public accountController(PersonaContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            // ViewBag.Account = GetDatos();
            //  var context = new CarteraContext();
            ViewBag.accounts = _context.Accounts.ToList();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(account account)
        {
            if (account.Nombre == null)
            {
                ModelState.AddModelError("Nombre", "El campo Nombre es erroneo");
            }
            else if(account.Apellido == null)
            {
                ModelState.AddModelError("Apellido", "El campo Apellido es erroneo");
            }
            else if (account.Username == null)
            {
                ModelState.AddModelError("Username", "El campo Username es erroneo");
            }
            else if (account.Password == null)
            {
                ModelState.AddModelError("Password", "El campo Password es erroneo");
            }

            if (ModelState.IsValid)
            {
                _context.Accounts.Add(account);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");
        }

    }
}
