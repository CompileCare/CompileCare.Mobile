using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilecare.Application.Dtos
{
    public class AuthDtos
    {
        public record SendOtpRequestDto(string MobileNumber);
        public record VerifyOtpRequestDto(string MobileNumber, string Otp);
        public record LoginResponseDto(string Token, string UserName);
    }
}
