using Data.Entities;

namespace Data.Repository
{
    public interface IUserRepository
    {
        List<User> Users { get; set; }

        void addUser(User userForAdd);
    }
}