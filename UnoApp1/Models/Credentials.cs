using Refit;
using System.Text.Json.Serialization;

namespace UnoApp1.Models;

public class Credentials
{
    [JsonPropertyName("username")]
    public string? Username { get; init; }
    [JsonPropertyName("password")]
    public string? Password { get; init; }
}
