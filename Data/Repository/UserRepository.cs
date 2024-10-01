using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public List<User> Users { get; set; }
        public UserRepository()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Username = "Cachito",
                    Password = "password123"
                },
                new User()
                {
                    Id = 2,
                    Username = "Sandra",
                    Password = "sandra123"
                },
                new User()
                {
                    Id = 3,
                    Username = "Messi",
                    Password = "messi3221"
                },
                new User()
                {
                    Id = 4,
                    Username = "DiMaria",
                    Password = "fideo22"
                }
            };
        }

        //Metodo para crear un usuario.
        public void addUser(User userForAdd)
        {
            Users.Add(userForAdd);
        }
    }
}
