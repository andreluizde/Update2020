using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema5.Models;

namespace Sistema5.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IAutenticacao _autentica;
        public ClienteController(IAutenticacao autentica)
        {
            _autentica = autentica;
        }

        [HttpGet]
        public IActionResult RegistrarCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarCliente([Bind] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                string RegistroStatus = _autentica.RegistrarCliente(cliente);
                if (RegistroStatus == "Sucesso")
                {
                    ModelState.Clear();
                    TempData["Sucesso"] = "Registro realizado com sucesso!";
                    return View();
                }
                else
                {
                    TempData["Falhou"] = "O Registro do cliente falhou.";
                    return View();
                }
            }
            return View();
        }
    }
}