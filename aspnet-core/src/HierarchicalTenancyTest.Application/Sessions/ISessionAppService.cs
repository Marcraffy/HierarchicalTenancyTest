using System.Threading.Tasks;
using Abp.Application.Services;
using HierarchicalTenancyTest.Sessions.Dto;

namespace HierarchicalTenancyTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
