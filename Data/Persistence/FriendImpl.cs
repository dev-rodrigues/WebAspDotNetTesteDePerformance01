using Core.Interface;
using Core.Model;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace Data.Persistence {
    public class FriendImpl : IFriend {

        private DataBaseContext db = new DataBaseContext();

        public bool CreateAsync(Friend obj) {

            try {
                db.Friends.Add(obj);
                var id = db.SaveChanges();
                var f = db.Friends.Find(id);
                return true;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            return false;
        }


        //    if(ModelState.IsValid) {
        //            db.Friends.Add(friend);
        //            await db.SaveChangesAsync();
        //            return Ok("Criado com sucesso");
        //}

        //Task<Friend> IFriend.CreateAsync(Friend obj) {
        //    db.Friends.Add(obj);
        //    var Id = db.SaveChanges();
        //    Task<Friend> t = db.Friends.Find(Id);
        //    return t;
        //}

        public List<Friend> FindAll() {
            throw new NotImplementedException();
        }

        public Friend FindById(string email) {
            throw new NotImplementedException();
        }

    }
}
