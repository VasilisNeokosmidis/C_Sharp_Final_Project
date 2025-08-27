using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peripatos.Core
{
    public class SessionContext
    {
        private UserProfile _user;
        public UserProfile User { get { return _user; } }
        public bool IsAuthenticated { get { return !_user.IsGuest; } }

        public event EventHandler Changed;

        public SessionContext(UserProfile initialUser)
        {
            _user = initialUser ?? UserProfile.Guest();
        }

        public void SignIn(UserProfile user)
        {
            _user = user;
            var h = Changed;
            if (h != null) h(this, EventArgs.Empty);
        }

        public void SignOut()
        {
            _user = UserProfile.Guest();
            var h = Changed;
            if (h != null) h(this, EventArgs.Empty);
        }
    }


}
