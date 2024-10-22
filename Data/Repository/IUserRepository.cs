using Data.Entities;

namespace Data.Repository
{
    public interface IUserRepository
    {
        void addUser(User userForAdd);
        public User? Get(string username);
    }
}