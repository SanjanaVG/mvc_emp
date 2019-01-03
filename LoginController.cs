using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emp_Mvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Logijn
        public ActionResult Login1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(Emp_Mvc.Models.LoginModel usermodel,string ReturnUrl)
        {


            using (empEntities db = new empEntities())
            {
                var EmpLogin = db.Tbl_Employee.Where(m => m.EmpId == usermodel.EmpId && m.Password1 == usermodel.Password && m.RoleId == 20001).FirstOrDefault();
                if (EmpLogin == null)
                {
                    usermodel.LoginMessage = "Wrong credentials";
                    return View("Login1", usermodel);
                }
                else
                {
                    usermodel.LoginMessage = "Login successful";
                    return View("Login1", usermodel);
                }
            }
            //return View();
        }
    }
}