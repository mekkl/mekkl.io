using System.Threading;
using System.Threading.Tasks;
using mekkl.Application.Common.Interfaces;
using mekkl.Application.Common.Interfaces.Services;
using mekkl.Domain.Common;
using mekkl.Domain.Entities;
using IdentityServer4.EntityFramework.Options;
using mekkl.Infrastructure.Identity;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Options;

namespace mekkl.Infrastructure.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTimeOffsetService _dateTimeOffsetService;

        public ApplicationDbContext(
            DbContextOptions options, 
            IOptions<OperationalStoreOptions> operationalStoreOption, 
            DbSet<Post> posts,
            ICurrentUserService currentUserService,
            IDateTimeOffsetService dateTimeOffsetService) : base(options, operationalStoreOption)
        {
            Posts = posts;
            _currentUserService = currentUserService;
            _dateTimeOffsetService = dateTimeOffsetService;
        }

        public DbSet<Post> Posts { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTimeOffsetService.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTimeOffsetService.UtcNow;
                        break;
                }
            }

            var result = await base.SaveChangesAsync(cancellationToken);

            // await DispatchEvents();

            return result;
        }
    }
}