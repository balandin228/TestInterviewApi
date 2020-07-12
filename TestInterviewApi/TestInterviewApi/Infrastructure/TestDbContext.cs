using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TestInterviewApi.Domain.PhoneNumber;
using TestInterviewApi.Domain.User;

namespace TestInterviewApi.Infrasctructure
{
    public class TestDbContext : DbContext
    {
        private readonly IMediator _mediator;
        public TestDbContext(DbContextOptions options) : base(options)
        {
        }
        public TestDbContext(DbContextOptions options, IMediator mediator) : base(options)
        {
            _mediator = mediator;
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
