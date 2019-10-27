using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class FriendBindingModel {

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

        public FriendBindingModel(string Name, string LastName, string Email, DateTime BirthDate) {
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.BirthDate = BirthDate;
        }
    }
}