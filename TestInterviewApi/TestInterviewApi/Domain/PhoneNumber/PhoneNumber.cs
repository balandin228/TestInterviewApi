namespace TestInterviewApi.Domain.PhoneNumber
{
    public class PhoneNumber : Entity<long>, IPhoneNumber
    {
        public string Number { get; }

        public long UserId { get; }
        public User.User User { get; }

        public PhoneNumber(string number, long userId)
        {
            Number = number;
            UserId = userId;
        }
        public PhoneNumber()
        {

        }
    }
}
