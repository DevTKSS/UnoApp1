using Refit;


namespace UnoApp1.Services.Endpoints;
[Headers("Content-Type: application/json")]
public interface IDummyJsonEndpoint
{
    Task<AuthResponse> Login(Credentials credentials, CancellationToken ct);
}
