using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers {
    public class FirstFriendController : Controller {

        private const string local = "http://localhost:50762/api/";


        // GET: FirstFriend
        public ActionResult Index() {

            List<FriendViewModel> friends = new List<FriendViewModel>();
            friends.Add(
                new FriendViewModel(1, "Carlos", "Santos", "carlos@gmail.com", DateTime.Now)                
            );

            friends.Add(
                new FriendViewModel(2, "Yuri", "Santos", "carlos@gmail.com", DateTime.Now)
            );

            //using(var client = new HttpClient()) {
            //    client.BaseAddress = new Uri(local);
            //    var response = await client.GetAsync("Friend/Friends");


            //    if(response.IsSuccessStatusCode) {
            //        Console.WriteLine(response.Content);

            //        var responseContent = await response.Content.ReadAsStringAsync();
            //        return RedirectToAction("Index", "FirstFriend");
            //    }
            //    return View("Error");
            //}

            TempData["Friends"] = friends;

            return View();
        }

        // GET: FirstFriend/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: FirstFriend/Create
        public ActionResult Create() {
            return View();
        }

        // POST: FirstFriend/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection) {
            try {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: FirstFriend/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: FirstFriend/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: FirstFriend/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: FirstFriend/Delete/5
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
