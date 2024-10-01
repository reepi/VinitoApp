using Common.DTOs;

namespace Services
{
    public interface IUserService
    {
        int createUser(UserForCreateDTO userForCreate);
    }
}