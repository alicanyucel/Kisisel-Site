using Kisisel_Site.Application.Features.Auth.Login;
using Kisisel_Site.Domain.Entities;

namespace Kisisel_Site.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
