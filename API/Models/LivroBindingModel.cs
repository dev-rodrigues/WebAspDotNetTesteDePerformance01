using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class LivroBindingModel {
        public string Nome {
            get; set;
        }

        public LivroBindingModel(string Nome) {
            this.Nome = Nome;        
        }
    }
}