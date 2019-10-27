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

        public bool Create(Friend obj) {

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

        public List<Friend> FindAll() {
            List<Friend> friends = new List<Friend>();
            friends.AddRange(db.Friends.ToList());
            return friends;
        }

        public Friend FindById(int id) {
            return db.Friends.Find(id);
        }
    }
}
