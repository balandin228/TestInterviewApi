using TestInterviewApi.Domain.PhoneNumber;

namespace TestInterviewApi.Infrastructure.Repositories
{
    public class PhoneNumberRepository : Repository<PhoneNumber>, IPhoneNumberRepository
    {
        public PhoneNumberRepository(TestDbContext context) : base(context)
        {
        }
    }
}
