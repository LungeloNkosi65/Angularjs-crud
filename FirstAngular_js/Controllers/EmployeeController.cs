//using FirstAngular_js.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace FirstAngular_js.Controllers
{
    //public class EmployeeController : Controller
    //{
    //    // GET: Employee
    //    private DrivingSchoolDbEntities db = new DrivingSchoolDbEntities();
    //     public JsonResult GetEmployees()
    //    {
    //        List<Employee> empList = db.Employees.ToList();
    //        return Json(empList, JsonRequestBehavior.AllowGet);
    //    }

    //    [HttpPost]
    //    public JsonResult Insert(Employee employee)
    //    {
    //        try
    //        {
    //            if (employee != null)
    //            {
    //                db.Employees.Add(employee);
    //                db.SaveChanges();
    //                return Json(new { success = true });
    //            }
    //            else
    //            {
    //                return Json(new { success = false });
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }

    //    [HttpPost]
    //    public JsonResult Update(Employee employee)
    //    {
    //        try
    //        {
    //            var dbRecord = db.Employees.Find(employee.EmpID);
    //            if (dbRecord != null)
    //            {
    //                dbRecord.EmpName = employee.EmpName;
    //                dbRecord.DeptName = employee.DeptName;
    //                dbRecord.Email = employee.Email;
    //                dbRecord.Designation = employee.Designation;
    //                db.SaveChanges();
    //                return Json(new { success = true });
    //            }
    //            else
    //            {
    //                return Json(new { success = false });
    //            }
    //        }
    //        catch (Exception ex)
    //        {

    //            throw ex;
    //        }
    //    }
    //    //POST Employee/Delete/1
    //    [HttpPost]
    //    public JsonResult Delete(int id)
    //    {
    //            Employee employee = db.Employees.Find(id);
    //            if (employee == null)
    //            {
    //                return Json(new { success = false });
    //            }
    //            db.Employees.Remove(employee);
    //            db.SaveChanges();
    //            return Json(new { success = true });
    //    }
    //}

   
}