namespace ServiceLib
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Entities;

    public class MessengerContext : DbContext
    {
        public MessengerContext()
            : base("name=MessengerContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<Dialog> Dialogues { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Membership> Memberships { get; set; }
    }
}