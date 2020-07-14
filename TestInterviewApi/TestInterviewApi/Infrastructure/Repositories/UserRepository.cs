using TestInterviewApi.Domain.User;

namespace TestInterviewApi.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TestDbContext context) : base(context)
        {
        }
    }
}
