using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HierarchicalTenancyTest.Roles.Dto;
using HierarchicalTenancyTest.Users.Dto;

namespace HierarchicalTenancyTest.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
