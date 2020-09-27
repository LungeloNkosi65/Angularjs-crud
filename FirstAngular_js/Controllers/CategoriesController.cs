using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAngular_js.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IServicesUnitOfWork _servicesUnitOfWork;
        public CategoriesController(IServicesUnitOfWork servicesUnitOfWork)
        {
            _servicesUnitOfWork = servicesUnitOfWork;
        }
        // GET: Categories
        public ActionResult Index()
        {
            try
            {
                var results = _servicesUnitOfWork.CategoryService.GetAll().ToList();
                return View(results);
            }
            catch (Exception ex)
            {

                return View();
            }
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                _servicesUnitOfWork.CategoryService.Add(category);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
