using Abp.Application.Services;
using VueLearning.MultiTenancy.Dto;

namespace VueLearning.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

