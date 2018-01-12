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

        public void AddNewAccount(Account account, UserProfile profile)
        {
            account.Profile = profile;
            profile.Account = account;
            Context.Accounts.Add(account);
            Context.Profiles.Add(profile);
        }

        public void AddNewDialog(Dialog dialog) {
            Context.Dialogues.Add(dialog);
        }

        public void AddMembership(Membership membership) {
            Context.Memberships.Add(membership);
        }

        public void AddMessage(Message message)
        {
            Context.Messages.Add(message);
        }

        public ICollection<Message> GetLastMessages(int dialogId) {
            return Context.Messages.Where(m => m.DialogId == dialogId).ToList();
        }

        public ICollection<Dialog> GetUserDialogues(int userId)
        {
            ICollection<Dialog> result = (from dialog in Context.Dialogues
                                         join membership in Context.Memberships
                                            on dialog.DialogId equals membership.DialogId
                                         join user in Context.Profiles
                                            on membership.AccountId equals user.AccountId
                                         where user.AccountId == userId
                                         select dialog).ToList();
            return result;
        }

        public void DeleteMembership(int membershipId) {
            Membership membership = Context.Memberships.Where(m => m.MembershipId == membershipId).FirstOrDefault();

            Context.Memberships.Remove(membership);
        }
    }
}
