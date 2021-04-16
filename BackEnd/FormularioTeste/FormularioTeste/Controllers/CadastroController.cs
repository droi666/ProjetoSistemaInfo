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
    public class CadastroController : Controller
    {
        // GET: Cadastro


        //Metódo
        public JsonResult SalvarCadastro(string form)
       {
            
            var lPessoa = JsonConvert.DeserializeObject<Pessoa>(form);
            if (lPessoa.nome == "")
            {
                return Json("O nome da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }
            
            if(lPessoa.sobrenome == "")
            {
                return Json("O sobrenome da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }
            
            if (lPessoa.cpf == "")
            {
                return Json("O CPF da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }
            
            if (lPessoa.endereco == "")
            {
                return Json("O endereço da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }
            if (lPessoa.cep == "")
            {
                return Json("O cep da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }

            if (lPessoa.cidade == "")
            {
                return Json("O cidade da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }
            if (lPessoa.estado == "")
            {
                return Json("O estado da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }

            if (lPessoa.telefone == "")
            {
                return Json("O telefone da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }
            if (lPessoa.celular == "")
            {
                return Json("O celular da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }

            if (lPessoa.email == "")
            {
                return Json("O email da pessoa está vazio!", JsonRequestBehavior.AllowGet);
            }
            if (lPessoa.observacoes == "")
            {
                return Json("A caixa de observações está vazia, por favor, nos diga algo sobre você!", JsonRequestBehavior.AllowGet);
            }
            var contador = 1;
            var quatroPrimeiros = "";

            for (int i = 0; i < lPessoa.cpf.Length; i++)
            {
             if(contador <= 4)
                {
                    quatroPrimeiros = quatroPrimeiros + lPessoa.cpf[i];
                    contador++;

                }
                else
                {
                    break;

                }


            }


            return Json("Pessoa cadastrada com sucesso, código " + quatroPrimeiros, JsonRequestBehavior.AllowGet);

        }
       


        }

    }