using ErrandWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SharedLibrary.Entities;
using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ErrandWebApi.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly SqlDbContext _context;
        private IConfiguration _configuration { get; }

        public IdentityService(SqlDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }


        public async Task<bool> CreateServiceWorkerAsync(SignUpModel model)
        {
            if(!_context.ServiceWorkers.Any(sw => sw.Email == model.Email))
            {
                try
                {
                    var sw = new ServiceWorker()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email
                    };
                    sw.CreatePasswordWithHash(model.Password);
                    _context.ServiceWorkers.Add(sw);
                    await _context.SaveChangesAsync();

                    return true;
                }
                catch
                {

                }                
            }

            return false;
        }

        public async Task<bool> CreateErrandAsync(CreateErrandModel model)
        {
            try
            {
                var errand = new Errand()
                {
                    CustomerName = model.CustomerName,
                    ServiceWorkerId = model.ServiceWorkerId,
                    Created = DateTime.Now,
                    Status = model.Status,
                    Description = model.Description
                };
                _context.Errands.Add(errand);
                await _context.SaveChangesAsync();

                return true;
            }
            catch { }

            return false;
        }

        public async Task<IEnumerable<Errand>> SearchStatusAsync(string status)
        {
            IQueryable<Errand> query = _context.Errands;

            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(e => e.Status.Contains(status));
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Errand>> SearchCustomerAsync(string customername)
        {
            IQueryable<Errand> query = _context.Errands;

            if (!string.IsNullOrEmpty(customername))
            {
                query = query.Where(e => e.CustomerName.Contains(customername));
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Errand>> SearchCreatedDateAsync(string createddate)
        {
            IQueryable<Errand> result = _context.Errands;

            if(DateTime.TryParse(createddate, out DateTime pdatetime))
            {
                result = result.Where(x => x.Created > pdatetime);
            }
            else if (createddate == "latest")
            {
                result = result.OrderByDescending(x => x.Created);
            }

            return await result.ToListAsync();
        }
    }
}
