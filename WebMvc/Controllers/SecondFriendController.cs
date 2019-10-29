﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class SecondFriendController : Controller
    {
        // GET: SecondFriend
        public ActionResult Index()
        {
            List<FriendViewModel> friends = new List<FriendViewModel>();
            friends.Add(
                new FriendViewModel(1, "Aristoteles", "A", "carlos@gmail.com", DateTime.Now)
            );

            friends.Add(
                new FriendViewModel(2, "Jamal", "B", "carlos@gmail.com", DateTime.Now)
            );

            friends.Add(
                new FriendViewModel(2, "Toninho", "C", "carlos@gmail.com", DateTime.Now)
            );

            TempData["Friends2"] = friends;

            return View();


            //using(var client = new HttpClient()) {
            //    client.BaseAddress = new Uri(local);
            //    var response = await client.GetAsync("Friend/Friends");


            //    if(response.IsSuccessStatusCode) {
            //        Console.WriteLine(response.Content);

            //        var responseContent = await response.Content.ReadAsStringAsync();


            //        var root = JsonConvert.DeserializeObject<FriendViewModel>(responseContent);

            //

            //return RedirectToAction("Index", "FirstFriend");

            //}

            //return View("Error");
        }
    }
}