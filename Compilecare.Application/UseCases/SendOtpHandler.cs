using Compilecare.Core.Interface;
using Compilecare.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Compilecare.Application.Dtos.AuthDtos;

namespace Compilecare.Application.UseCases
{
    public class SendOtpHandler
    {
        private readonly IAuthApi _auth;

        public SendOtpHandler(IAuthApi auth) => _auth = auth;

        public async Task<bool> HandleAsync(SendOtpRequestDto request, CancellationToken ct = default)
        {
            if (!PhoneValidator.IsValidIndianMobile(request.MobileNumber))
                return false;

            return await _auth.SendOtpAsync(request.MobileNumber, ct);
        }
    }
}
