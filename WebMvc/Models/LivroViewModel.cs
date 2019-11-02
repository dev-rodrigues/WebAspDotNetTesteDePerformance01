using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.Models {
    public class LivroViewModel {
        public int Id {
            get; set;
        }

        public string Nome {
            get; set;
        }

        public LivroViewModel(int id, string nome) {
            this.Id = id;
            this.Nome = nome;
        }

        public LivroViewModel() {

        }


    }
}