using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface {
    public interface IFriend {

        bool CreateAsync(Friend obj);

        Friend FindByEmail(string email);

        List<Friend> FindAll();
    }
}
