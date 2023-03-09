using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Correios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TESTE.DAL;
using TESTE.Models;
using WSCorreios;

namespace TESTE.Controllers
{
    public class CorreiosController : Controller
    {
        private readonly BancoContext _context;

        public CorreiosController(BancoContext context)
        {
            _context = context;
        }

        // GET: TB_NUMEROS
        public IActionResult Index()
        {
              return View();
        }
        public ObjectResult GetCEP([FromUri] string CEP)
        {
            using (var ws = new CorreiosApi())
            {
                var dados = ws.consultaCEP(CEP);

                
                return Ok(dados);
            }
        }
 
    }
}
