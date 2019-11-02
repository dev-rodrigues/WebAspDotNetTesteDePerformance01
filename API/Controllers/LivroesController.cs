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
using Core.Service;
using Data.Context;
using Data.Persistence;

namespace API.Controllers {

    [RoutePrefix("api/Livroes")]
    public class LivroesController : ApiController {

        private DataBaseContext db = new DataBaseContext();
        private ILivro livroService = ServiceLocator.InstanciarLivros<LivroImpl>();

        [AllowAnonymous]
        [System.Web.Http.Route("Create")]
        [HttpPost]
        public IHttpActionResult Create(LivroBindingModel Livro) {

            var obj = new Livro(Livro.Nome);

            var criou = livroService.Create(obj);

            if(criou) {
                return Ok("Livro criado com sucesso");
            }

            return BadRequest("deu merda");
        }

        [AllowAnonymous]
        [Route("Livro")]
        [HttpGet]
        public IHttpActionResult Livro(int id) {
            Livro obj = livroService.FindLivroById(id);

            if(obj != null) {
                return Ok(obj);
            }
            return BadRequest("Error finding friend");
        }
    }
}
