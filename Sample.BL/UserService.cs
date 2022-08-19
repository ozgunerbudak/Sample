using Sample.Core.Helper;
using Sample.Dal;
using Sample.Domain.Entities;
using Sample.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BL
{
    public class UserService : IUserService
    {

        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserModel> GetAllUser()
        {
            var users = _userRepository.GetAllUser();
            return users.Select(s => new UserModel()
            {
                Id = s.Id,
                FullName = s.Name + " " + s.LastName
            }).ToList();
        }

        public void CreateUser()
        {
            User user = new();
            user.Name= GenerateUserNameHelper.GenerateUserName();
            _userRepository.Create(user);
        }
    }

    public class UserSerivice2 : IUserService
    {
        public void CreateUser()
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAllUser()
        {
            //   _userExcell.Users();
            return null;
        }
    }
}
