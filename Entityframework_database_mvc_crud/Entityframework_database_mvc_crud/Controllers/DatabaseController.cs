using Entityframework_database_mvc_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entityframework_database_mvc_crud.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult DatabaseIndex()
        {
            return View();
        }
        public void met_ins(tblEmployee obj)
        {
            if(obj.empid == 0)
            {
                db90_18124Entities en = new db90_18124Entities();
                en.employee_insert(obj.name, obj.city, obj.mobile, obj.age);
                en.SaveChanges();
            }
            else
            {
                db90_18124Entities en = new db90_18124Entities();
                en.employee_update(obj.empid,obj.name,obj.city,obj.mobile,obj.age);
                en.SaveChanges();
            }
        }
        public JsonResult met_dis()
        {
            db90_18124Entities pq = new db90_18124Entities();
            var data = pq.employee_get().ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public void met_dlt(int A)
        {
            db90_18124Entities mn = new db90_18124Entities();
            var data = mn.employee_delete(A);
            mn.SaveChanges();
        }
        public JsonResult met_edt(int A)
        {
            db90_18124Entities pq = new db90_18124Entities();
            var data = pq.employee_edit(A).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}