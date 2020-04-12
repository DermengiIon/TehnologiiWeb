using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic.DbModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name = eUseControl")
        {

        }
        public virtual DbSet<UsersDbTable> Users { get; set; }
    }
}
