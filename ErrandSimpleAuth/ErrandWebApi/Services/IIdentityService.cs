using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrandWebApi.Services
{
    public interface IIdentityService
    {
        Task<bool> CreateServiceWorkerAsync(SignUpModel model);


        Task<SignInResponse> SignInAsync(string email, string password);
    }
}
