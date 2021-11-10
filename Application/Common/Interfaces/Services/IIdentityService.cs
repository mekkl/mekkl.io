using System.Threading.Tasks;

namespace mekkl.Application.Common.Interfaces.Services
{
    public interface IIdentityService
    {
        public Task<string> GetUserNameAsync(string userId);
    }
}