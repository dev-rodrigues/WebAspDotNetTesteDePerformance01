using Core.Model;
using Core.Service;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistence {
    public class LivroImpl : ILivro {

        private DataBaseContext Database = new DataBaseContext();

        public bool Create(Livro livro) {

            try {
                Database.Livros.Add(livro);
                var id = Database.SaveChanges();
                return true;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public Livro FindLivroById(int id) {            
            var obj = Database.Livros.Find(id);
            return obj;
        }
    }
}
