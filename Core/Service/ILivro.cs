using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service {
    public interface ILivro {

        bool Create(Livro livro);

        Livro FindLivroById(int id);
        
    }
}
