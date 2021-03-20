using SharedLibrary.Entities;
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
        Task<bool> CreateErrandAsync(CreateErrandModel model);
        Task<IEnumerable<Errand>> SearchStatusAsync(string status);
        Task<IEnumerable<Errand>> SearchCustomerAsync(string customername);
        Task<IEnumerable<Errand>> SearchCreatedDateAsync(string createddate);
    }
}
