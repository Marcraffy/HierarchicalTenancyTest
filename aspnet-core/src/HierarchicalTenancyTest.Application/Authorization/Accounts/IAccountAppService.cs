using System.Threading.Tasks;
using Abp.Application.Services;
using HierarchicalTenancyTest.Authorization.Accounts.Dto;

namespace HierarchicalTenancyTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
