using Sample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Dal
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUser()
        {
            return null;
        }

        public void Create(User user )
        {

        }
    }
}
