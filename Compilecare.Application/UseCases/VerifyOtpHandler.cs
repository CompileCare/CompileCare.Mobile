using Compilecare.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Compilecare.Application.Dtos.AuthDtos;

namespace Compilecare.Application.UseCases
{
    public class VerifyOtpHandler
    {
        private readonly IAuthApi _auth;

        public VerifyOtpHandler(IAuthApi auth) => _auth = auth;

        public async Task<LoginResponseDto?> HandleAsync(VerifyOtpRequestDto request, CancellationToken ct = default)
        {
            var result = await _auth.VerifyOtpAsync(request.MobileNumber, request.Otp, ct);
            if (result is null) return null;
            return new LoginResponseDto(result.Token, result.UserName);
        }
    }
}
