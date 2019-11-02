using Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context {
    public class DataBaseContext : DbContext {
        public DbSet<Friend> Friends {
            get; set;
        }

        public DbSet<Livro> Livros {
            get; set;
        }
    }
}
