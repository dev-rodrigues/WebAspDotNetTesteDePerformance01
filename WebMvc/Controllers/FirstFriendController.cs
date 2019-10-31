using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        private static List<FriendViewModel> list = new List<FriendViewModel>();

        // GET: FirstFriend
        public async Task<ActionResult> Index() {

            List<FriendViewModel> friends = new List<FriendViewModel>();

            using(var client = new HttpClient()) {
                client.BaseAddress = new Uri(local);
                var response = await client.GetAsync("Friend/Friends");

                if(response.IsSuccessStatusCode) {
                    Console.WriteLine(response.Content);

                    var responseContent = await response.Content.ReadAsStringAsync();

                    friends = JsonConvert.DeserializeObject<List<FriendViewModel>>(responseContent);

                    ViewBag.Friends = friends;
                    TempData["Friends"] = friends;
                    list = friends;
                }
                return View();
            }
        }

        [HttpPost]
        public ActionResult Index(List<FriendViewModel> lista, FormCollection form) {

            var list = TempData["Friends"] as List<FriendViewModel>;

            TempData.Remove("Friends");
            TempData["Friends"] = list;

            return RedirectToAction("Index", "SecondFriend");
        }

        [HttpPost]
        public ActionResult Index2(List<FriendViewModel> lista, FormCollection form) {

            var list = TempData["Friends"] as List<FriendViewModel>;

            TempData.Remove("Friends");
            TempData["Friends"] = list;

            return RedirectToAction("Index", "FirstFriend");
        }


    }
}
