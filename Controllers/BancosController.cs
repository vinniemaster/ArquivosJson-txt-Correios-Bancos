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
    public class BancosController : Controller
    {
        public IActionResult Index()
        {
              return View();
        }
 
    }
}
