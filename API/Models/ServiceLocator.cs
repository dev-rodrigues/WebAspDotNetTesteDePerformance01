﻿using Core.Interface;
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

        internal static T GetInstanceOf<T>() {
            return Activator.CreateInstance<T>();
        }
    }
}