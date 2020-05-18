using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorApp17.Client
{
    public class RolesAccount : RemoteUserAccount
    {
        [JsonPropertyName("role")]
        public string[] Roles { get; set; }
    }
}
