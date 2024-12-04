using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UnoApp1.Models;

public class AuthResponse
{
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}
