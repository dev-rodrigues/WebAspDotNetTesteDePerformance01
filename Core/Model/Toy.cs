using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model {
    public class Toy {
        public int Id {
            get; set;
        }

        public string Name {
            get; set;
        }

        public virtual Friend Friend {
            get; set;
        }

        [ForeignKey("Friend")]
        public int IdFriend {
            get; set;
        }
    }
}
