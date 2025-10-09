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
        public int UserID { get; }
        public string Username { get; }
        public bool IsGuest { get; }

        private UserProfile(int userId, string username, bool isGuest)
        {
            UserID = userId;
            Username = username;
            IsGuest = isGuest;
        }

        public static UserProfile Guest()
        {
            return new UserProfile(0, "guest", true);
        }

        public static UserProfile Create(int userId, string username)
        {
            if (string.IsNullOrWhiteSpace(username)) username = "user";
            return new UserProfile(userId, username, false);
        }

    }
}
