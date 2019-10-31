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
                    list = friends;
                }
                return View();
            }
        }

        [HttpPost]
        public ActionResult Index(List<FriendViewModel> lista, FormCollection form) {
            var selected = form["Selected"].Split(',');

            List<FriendViewModel> newList = new List<FriendViewModel>();

            for(int i = 0; i < selected.Length; i++) {
                foreach(FriendViewModel f in list) {
                    if(selected[i].Equals("true")) {
                        f.Selected = true;
                    } else {
                        f.Selected = false;
                    }
                    newList.Add(f);
                }
            }

            ViewBag.Friends = newList;

            return View();
        }

        
    }
}
