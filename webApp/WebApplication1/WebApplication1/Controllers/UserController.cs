using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public Usuario Get(string username, string senha)
        {
            tictactoeEntities entities = new tictactoeEntities();
            Usuario logado = entities.Usuario.FirstOrDefault(u => u.username == username && u.senha == senha);
            return logado;
        }
    }
}