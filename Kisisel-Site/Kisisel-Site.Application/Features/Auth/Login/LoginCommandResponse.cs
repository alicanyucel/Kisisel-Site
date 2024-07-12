namespace Kisisel_Site.Application.Features.Auth.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string RefreshToken,
        DateTime RefreshTokenExpires);
}
