using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HierarchicalTenancyTest.MultiTenancy.Dto;

namespace HierarchicalTenancyTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
