﻿namespace TestInterviewApi.Domain.User
{
    public interface IUser
    {
        long Key { get; }
        string LastName { get; }
        string FirstName { get; }
        string Login { get; }
        string PhoneNumber { get; }
        string PasswordHash { get; }
        string Salt { get; }
    }
}
