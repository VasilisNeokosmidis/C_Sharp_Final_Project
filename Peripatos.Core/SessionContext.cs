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
        public VisitHistory History { get; private set; }

        public event EventHandler Changed;

        public SessionContext(UserProfile initialUser)
        {
            _user = initialUser ?? UserProfile.Guest();
            History = new VisitHistory();
            LoadUserHistory();
        }

        public void SignIn(UserProfile user)
        {
            _user = user;
            // Load fresh history for the new user
            History.ClearHistory();
            LoadUserHistory();
            
            var h = Changed;
            if (h != null) h(this, EventArgs.Empty);
        }

        public void SignOut()
        {
            _user = UserProfile.Guest();
            // Clear history when signing out
            History.ClearHistory();
            var h = Changed;
            if (h != null) h(this, EventArgs.Empty);
        }

        public void MarkFormVisited(string formName)
        {
            History.MarkFormVisited(formName);
            
            // Save to database for authenticated users
            if (IsAuthenticated && !_user.IsGuest)
            {
                try
                {
                    Database.SaveUserFormVisit(_user.UserID, formName);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error saving form visit: {ex.Message}");
                }
            }
        }

        private void LoadUserHistory()
        {
            if (IsAuthenticated && !_user.IsGuest)
            {
                try
                {
                    var dbHistory = Database.LoadUserFormHistory(_user.UserID);
                    History.LoadFromDatabase(dbHistory);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error loading user history: {ex.Message}");
                }
            }
        }

        public void ClearUserHistory()
        {
            History.ClearHistory();
            
            if (IsAuthenticated && !_user.IsGuest)
            {
                try
                {
                    Database.ClearUserFormHistory(_user.UserID);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error clearing user history: {ex.Message}");
                }
            }
        }
    }
}
