using Core.Interface;
using Core.Service;
using Data.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class ServiceLocator {
        private static Dictionary<Type, Type> dependencies = new Dictionary<Type, Type> {
            [typeof(IFriend)] = typeof(FriendImpl)
        };

        private static Dictionary<Type, Type> livroDb = new Dictionary<Type, Type> {
            [typeof(ILivro)] = typeof(LivroImpl)
        };

        internal static T GetInstanceOf<T>() {
            return Activator.CreateInstance<T>();
        }
        internal static T InstanciarLivros<T>() {
            return Activator.CreateInstance<T>();
        }
    }
}