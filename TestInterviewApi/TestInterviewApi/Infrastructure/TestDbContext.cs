using MediatR;
using Microsoft.EntityFrameworkCore;
using TestInterviewApi.Domain.PhoneNumber;
using TestInterviewApi.Domain.User;

namespace TestInterviewApi.Infrastructure
{
    public class TestDbContext : DbContext
    {
        private readonly IMediator _mediator;
        public TestDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
