using Sample.Domain.Model;

namespace Sample.BL
{
    public interface IUserService
    {
        void CreateUser();
        List<UserModel> GetAllUser();
    }
}