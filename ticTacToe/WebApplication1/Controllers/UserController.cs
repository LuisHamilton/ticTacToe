using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UserController : ApiController
    {
        public Usuario Get(string username,string senha)
        {
            tictactoeEntities entities = new tictactoeEntities();
            Usuario logado = entities.Usuario.FirstOrDefault(u => u.username == username && u.senha == senha);
            return logado;
        }
    }
}
