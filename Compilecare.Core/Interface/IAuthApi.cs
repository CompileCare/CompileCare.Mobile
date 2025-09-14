using Compilecare.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilecare.Core.Interface
{
    public interface IAuthApi
    {
        Task<bool> SendOtpAsync(string mobileNumber, CancellationToken ct = default);
        Task<LoginResult?> VerifyOtpAsync(string mobileNumber, string otp, CancellationToken ct = default);
    }
}
