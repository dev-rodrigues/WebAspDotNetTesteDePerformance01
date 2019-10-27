using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.Models {
    public class FriendViewModel {
        public int Id {
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

        public FriendViewModel(int Id, string Name, string LastName, string Email, DateTime BirthDate) {
            this.Id = Id;
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.BirthDate = BirthDate;
        }

        public List<FriendViewModel> FriendsModels(List<Friend> friends) {
            List<FriendViewModel> list = new List<FriendViewModel>();

            foreach(Friend f in friends) {
                FriendViewModel obj = new FriendViewModel(f.Id, f.Name, f.LastName, f.Email, f.BirthDate);
                list.Add(obj);
            }
            return list;
        }
    }
}