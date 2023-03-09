using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TESTE.DAL;
using TESTE.Models;

namespace TESTE.Controllers
{
    public class NumerosController : Controller
    {
        private readonly BancoContext _context;

        public NumerosController(BancoContext context)
        {
            _context = context;
        }

        // GET: TB_NUMEROS
        public async Task<IActionResult> Index()
        {
              return View(await _context.TB_NUMEROS.ToListAsync());
        }
        public async Task<IActionResult> DeleteAll()
        {
            var numbers_all = await _context.TB_NUMEROS.ToListAsync();

            foreach(var item in numbers_all)
            {
                _context.TB_NUMEROS.Remove(item);
            }
            _context.SaveChanges();
            //return View(await _context.TB_NUMEROS.ToListAsync());
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> GerarTxt()
        {
            StreamWriter txt = new StreamWriter("arquivo.txt");
            var numbers_all = await _context.TB_NUMEROS.OrderBy(x => x.NUMEROS).ToListAsync();
            foreach(var item in numbers_all)
            {
                txt.WriteLine(item.NUMEROS);
            }
            txt.Close();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return PartialView("Create");
        }
        // GET: TB_NUMEROS/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TB_NUMEROS tB_NUMEROS)
        {
            if (ModelState.IsValid)
            {
                tB_NUMEROS.ID_REGISTRO = Guid.NewGuid();
                _context.Add(tB_NUMEROS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tB_NUMEROS);
        }


        // POST: TB_NUMEROS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.TB_NUMEROS == null)
            {
                return Problem("Entity set 'BancoContext.TB_NUMEROS'  is null.");
            }
            var tB_NUMEROS = await _context.TB_NUMEROS.FindAsync(id);
            if (tB_NUMEROS != null)
            {
                _context.TB_NUMEROS.Remove(tB_NUMEROS);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TB_NUMEROSExists(Guid id)
        {
          return _context.TB_NUMEROS.Any(e => e.ID_REGISTRO == id);
        }
    }
}
