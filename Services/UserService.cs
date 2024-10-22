using Common.DTOs;
using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        #region Inyecction de UserRepo
        private readonly IUserRepository _userRepo;
        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        #endregion

        public int createUser(UserForCreateDTO userForCreate)
        {
            //El Service se encarga de pasar el DTO a entidad
            User newUser = new User()
            {
                Username = userForCreate.Username,
                Password = userForCreate.Password
            };
            _userRepo.addUser(newUser);

            return newUser.Id;
        }

        public User? AuthenticateUser(string username, string password)
        {
            User? userToReturn = _userRepo.Get(username);
            if (userToReturn is not null && userToReturn.Password == password)
                return userToReturn;
            return null;
        }
    }
}
