using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInterviewApi.Domain.User
{
    public class User : Entity<long>, IUser
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public string Login { get; }
        public string PhoneNumber { get; private set; }

        public string PasswordHash { get;}
        public string Salt { get; }
        public ICollection<PhoneNumber.PhoneNumber> Numbers { get; }

        public User()
        {
        }

        public User(string login, string passwordHash, string salt)
        {
            Login = login;
            PasswordHash = passwordHash;
            Salt = salt;
        }

        public void UpdateFirstName(string name)
        {
            FirstName = name;
        }

        public void UpdateLastName(string name)
        {
            LastName = name;
        }

        public void UpdatePhoneNumber(string phone)
        {
            PhoneNumber = phone;
        }

    }
}
