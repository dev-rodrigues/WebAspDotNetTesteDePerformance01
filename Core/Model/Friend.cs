using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model {
    public class Friend {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id {
            get; set;
        }

        public string Name {
            get; set;
        }

        public string LastName {
            get; set;
        }

        
        public string Email {
            get; set;
        }

        public DateTime BirthDate {
            get; set;
        }
    }
}
