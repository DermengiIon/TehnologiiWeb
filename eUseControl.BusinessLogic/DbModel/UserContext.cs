﻿using System.Data.Entity;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic.DbModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name = eUseControl")
        {
            /*Database.SetInitializer<UserContext>(null);*/
        }
        public virtual DbSet<SessionsDbTable> Sessions { get; set; }
        public virtual DbSet<UsersDbTable> Users { get; set; }
    }
}
