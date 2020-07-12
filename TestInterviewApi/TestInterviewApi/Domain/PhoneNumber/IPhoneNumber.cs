using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInterviewApi.Domain.PhoneNumber
{
    public interface IPhoneNumber
    {
        string Number { get; }
        long Key { get; }
    }
}
