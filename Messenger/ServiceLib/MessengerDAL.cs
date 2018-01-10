using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLib.Entities;

namespace ServiceLib
{
    public class MessengerDAL
    {
        public MessengerContext Context { get; set; }

        public MessengerDAL()
        {
            Context = new MessengerContext();
        }

        public Account GetAccountByLogin(string login)
        {
            return Context.Accounts.Where(a => a.Login == login).FirstOrDefault();
        }

        public void RegisterNewAccount(Account account, UserProfile profile)
        {
            account.Profile = profile;
            profile.Account = account;
            Context.Accounts.Add(account);
            Context.Profiles.Add(profile);
        }

        public ICollection<Dialog> GetUserDialogues(int userId)
        {
            ICollection<Dialog> result = (from dialog in Context.Dialogues
                                         join membership in Context.Memberships
                                            on dialog.DialogId equals membership.DialogId
                                         join user in Context.Profiles
                                            on membership.UserProfileId equals user.AccountId
                                         where user.AccountId == userId
                                         select dialog).ToList();
            return result;
        }
    }
}
