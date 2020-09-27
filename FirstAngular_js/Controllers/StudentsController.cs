using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAngular_js.Controllers
{
    public class StudentsController : Controller
    {

        private readonly IServicesUnitOfWork  _servicesUnitOfWork;
        public StudentsController(IServicesUnitOfWork servicesUnitOfWork)
        {
            _servicesUnitOfWork = servicesUnitOfWork;
        }

        // GET: Students
        public ActionResult Index()
        {
            var results = _servicesUnitOfWork.StudentService.GetAll().ToList();
            return View(results);
        }
    }
}