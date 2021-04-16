using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormularioTeste.Models;
using Newtonsoft.Json;

namespace FormularioTeste.Controllers
{
    [AllowAnonymous]
    public class UsuarioController : Controller
    {
        // GET: Cadastro


        //Metódo
        public JsonResult SalvarUsuario(string form)
        {

            var result = new JsonResult();
            var lUsuario = JsonConvert.DeserializeObject<Login>(form);
            if (lUsuario.Usuario.ToLower() == "sistema")
            {
                result = Json("O nome deu suario está correto!", JsonRequestBehavior.AllowGet);
            }
            if (lUsuario.Usuario.ToLower() != "")
            {
                result = Json("O nome deu suario está incorreto!", JsonRequestBehavior.AllowGet);
            }
                var lSenha = JsonConvert.DeserializeObject<Login>(form);
            if (lSenha.Senha.Equals(""))
            {
                result = Json("A senha está incorreta!", JsonRequestBehavior.AllowGet);
            }
            if (lSenha.Senha == "candidato123")
            {
                result = Json("Bem vindo ao cadastro!", JsonRequestBehavior.AllowGet);
            }
            return result;

        }

    }
}