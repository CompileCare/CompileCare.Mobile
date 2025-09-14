using Compilecare.Core.Interface;
using Compilecare.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Compilecare.Infrastructure.API
{
    public class AuthApi : IAuthApi
    {
        private readonly HttpClient _http;

        public AuthApi(HttpClient http) => _http = http;

        public async Task<bool> SendOtpAsync(string mobileNumber, CancellationToken ct = default)
        {
            var payload = new { mobileNumber };
            var res = await _http.PostAsJsonAsync("/auth/send-otp", payload, ct);
            return res.IsSuccessStatusCode;
        }

        public async Task<LoginResult?> VerifyOtpAsync(string mobileNumber, string otp, CancellationToken ct = default)
        {
            var payload = new { mobileNumber, otp };
            var res = await _http.PostAsJsonAsync("/auth/verify-otp", payload, ct);
            if (!res.IsSuccessStatusCode) return null;

            // Expected: { token, userName }
            var dto = await res.Content.ReadFromJsonAsync<LoginResult>(cancellationToken: ct);
            return dto;
        }
    }
}
