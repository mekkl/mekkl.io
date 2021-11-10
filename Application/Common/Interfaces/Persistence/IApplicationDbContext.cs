using System.Threading;
using System.Threading.Tasks;
using mekkl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace mekkl.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Post> Posts { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}