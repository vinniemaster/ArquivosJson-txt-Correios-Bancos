using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TESTE.DAL;
using TESTE.Models;

namespace TESTE.Controllers
{
    public class ArquivoJsonController : Controller
    {
        private readonly BancoContext _context;

        public ArquivoJsonController(BancoContext context)
        {
            _context = context;
        }

        // GET: ArquivoJson
        public IActionResult Index()
        {
              return View();
        }

        public IEnumerable<TB_JSON> GetAllNumbers()
        {
            using (StreamReader r = new StreamReader("data.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<TB_JSON>>(json);
                return items;
            }
            
        }
        public IActionResult Create()
        {
            return PartialView("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FILTRO qte)
        {
            if (ModelState.IsValid)
            {
                StreamWriter txt = new StreamWriter("data.json");
                var list = new List<TB_JSON>();

                var i = 0;

                for (i = 1; i <= qte.QTDE; i++)
                {
                    var numero = new TB_JSON() {ID_REGISTRO = Guid.NewGuid(), CODIGO = i, Timestamp = DateTime.Now};
                    list.Add(numero);
                }
                
                txt.Write(JsonConvert.SerializeObject(list));
                txt.Close();

                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
