using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers {
    public class LivroController : Controller {

        private const string local = "http://localhost:50762/api/";

        // GET: Livro
        public async Task<ActionResult> Index() {

            LivroViewModel lv = new LivroViewModel();

            using(var client = new HttpClient()) {
                client.BaseAddress = new Uri(local);
                var response = await client.GetAsync("Livroes/Livro?id=1");

                if(response.IsSuccessStatusCode) {

                    var responseContent = await response.Content.ReadAsStringAsync();

                    lv = JsonConvert.DeserializeObject<LivroViewModel>(responseContent);

                }

            }

            List<LivroViewModel> ls = new List<LivroViewModel>();
            ls.Add(lv);
            ls.Add(lv);
            return View(ls);
        }

        // GET: Livro/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: Livro/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Livro/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection) {
            try {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: Livro/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: Livro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: Livro/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: Livro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }
    }
}
