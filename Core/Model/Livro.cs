using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model {

    public class Livro {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {
            get; set;
        }

        public string Nome {
            get; set;
        }

        public Livro(string Nome) {
            this.Nome = Nome;
        }

        public Livro() {
            
        }
    }
}