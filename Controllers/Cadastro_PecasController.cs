using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Museu_da_Informática.Models;

namespace Museu_da_Informática.Controllers
{
    public class Cadastro_PecasController : Controller
    {
        private ModeloDados db = new ModeloDados();
        private Cadastro_Pecas Dados = new Cadastro_Pecas();

        // GET: Cadastro_Pecas
       [Authorize]
        public async Task<ActionResult> Index()
        {
            return View(await db.Cadastro_Pecas.ToListAsync());
        }

        // GET: Cadastro_Pecas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Pecas cadastro_Pecas = await db.Cadastro_Pecas.FindAsync(id);
            if (cadastro_Pecas == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Pecas);
        }

        // GET: Cadastro_Pecas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cadastro_Pecas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,tipo,marca,modelo,peso,dimensao_largura,dimensao_altura,dimensao_profundidade,memoria,ano_fabricacao,diponibilidade_venda,diponibilidade_visual")] Cadastro_Pecas cadastro_Pecas)
        {
            if (ModelState.IsValid)
            {
                db.Cadastro_Pecas.Add(cadastro_Pecas);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cadastro_Pecas);
        }

        // GET: Cadastro_Pecas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Pecas cadastro_Pecas = await db.Cadastro_Pecas.FindAsync(id);
            if (cadastro_Pecas == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Pecas);
        }

        // POST: Cadastro_Pecas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,tipo,marca,modelo,peso,dimensao_largura,dimensao_altura,dimensao_profundidade,memoria,ano_fabricacao,diponibilidade_venda,diponibilidade_visual")] Cadastro_Pecas cadastro_Pecas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastro_Pecas).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cadastro_Pecas);
        }

        // GET: Cadastro_Pecas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Pecas cadastro_Pecas = await db.Cadastro_Pecas.FindAsync(id);
            if (cadastro_Pecas == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Pecas);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        
        [AllowAnonymous]
        public async Task<ActionResult> Exibir2(string search)
        {
            if (search == null || search == "")
            {
                var query = from c in db.Cadastro_Pecas
                            where c.diponibilidade_visual == true
                            select c;
                List<Cadastro_Pecas> data = await query.ToListAsync();
                              
                                     
                return View(data);
               
            }
            else
            {
                var query = from c in db.Cadastro_Pecas
                            where c.tipo == search
                            select c;
                List<Cadastro_Pecas> data = await query.ToListAsync();
               
                return View(data);
               
            }

            
       
    
        }
    }
}
