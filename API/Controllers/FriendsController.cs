using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using API.Models;
using Core.Interface;
using Core.Model;
using Data.Context;
using Data.Persistence;

namespace API.Controllers {

    [Authorize]
    [RoutePrefix("api/Friend")]
    public class FriendsController : ApiController {

        private DataBaseContext db = new DataBaseContext();
        private IFriend friendService = ServiceLocator.GetInstanceOf<FriendImpl>();

        [AllowAnonymous]
        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Create(FriendBindingModel model) {

            var friend = new Friend() {
                Name = model.Name,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                Email = model.Email,
            };

            var created = false;

            if(ModelState.IsValid) {
                created = friendService.CreateAsync(friend);
            }

            if(created) {
                return Ok($"Successfully Created Friend");
            }

            return BadRequest("Error ao criar um Amigo");
        }

    }
}
