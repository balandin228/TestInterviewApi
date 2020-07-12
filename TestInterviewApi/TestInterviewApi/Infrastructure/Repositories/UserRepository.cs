using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestInterviewApi.Domain.User;

namespace TestInterviewApi.Infrastructure.Repositories
{
    public class  UserRepository : Repository<User>
    {
        public UserRepository(TestDbContext context) : base(context)
        {
        }
    }
}
