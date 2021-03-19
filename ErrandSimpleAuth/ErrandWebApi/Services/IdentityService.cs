using ErrandWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
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

        public async Task<SignInResponse> SignInAsync(string email, string password)
        {
            try
            {
                var serviceworker = await _context.ServiceWorkers.FirstOrDefaultAsync(serviceworker => serviceworker.Email == email);

                if (serviceworker != null)
                {
                    try
                    {
                        if (serviceworker.ValidatePasswordHash(password))
                        {
                            var tokenHandler = new JwtSecurityTokenHandler();
                            var _secretKey = Encoding.UTF8.GetBytes(_configuration.GetSection("SecretKey").Value);
                            var expireDate = DateTime.Now.AddHours(5);

                            var tokenDescriptor = new SecurityTokenDescriptor
                            {
                                Subject = new ClaimsIdentity(new Claim[]
                                {
                                    new Claim("ServiceWorkerId", serviceworker.Id.ToString()),
                                    new Claim("Expires", expireDate.ToString())
                                }),
                                Expires = expireDate,
                                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(_secretKey), SecurityAlgorithms.HmacSha512Signature)
                            };

                            var _accessToken = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));


                            return new SignInResponse
                            {
                                Succeded = true,
                                Result = new SignInResponseResult
                                {
                                    Id = serviceworker.Id,
                                    Email = serviceworker.Email,
                                    AccessToken = _accessToken
                                }
                            };
                        }
                    }
                    catch { }
                }
            }
            catch { }

            return new SignInResponse { Succeded = false };

        }
    }
}
