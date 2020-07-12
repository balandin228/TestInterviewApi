using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestInterviewApi.Domain.PhoneNumber;

namespace TestInterviewApi.Infrastructure.Repositories
{
    public class PhoneNumberRepository : Repository<PhoneNumber>
    {
        public PhoneNumberRepository(TestDbContext context) : base(context)
        {
        }
    }
}
