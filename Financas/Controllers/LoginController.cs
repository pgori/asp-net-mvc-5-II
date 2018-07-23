using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace Financas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String login, String senha)
        {
            try
            {
                if (WebSecurity.Login(login, senha))
                {
                    return RedirectToAction("Index", "Movimentacao");
                }
                else
                {
                    return View("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("login.Invalido", e.Message);
                return View("Index");
            }
        }

        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index");
        }
    }
}