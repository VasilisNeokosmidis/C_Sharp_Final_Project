using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Peripatos.Core
{
    public class UserProfile
    {
        public string Username { get; }
        public bool IsGuest { get; }

        private UserProfile(string username,bool isGuest)
        {
            Username = username;
            IsGuest = isGuest;
        }

        public static UserProfile Guest()
        {
            return new UserProfile("guest", true);
        }

        public static UserProfile Create(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) username = "user";
            return new UserProfile(username, false);
        }

    }
}
