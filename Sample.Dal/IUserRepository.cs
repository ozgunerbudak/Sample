using Sample.Domain.Entities;

namespace Sample.Dal
{
    public interface IUserRepository
    {
        void Create(User user);
        List<User> GetAllUser();
    }
}