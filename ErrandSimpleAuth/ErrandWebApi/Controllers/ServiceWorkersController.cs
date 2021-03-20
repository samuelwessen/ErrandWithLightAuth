using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ErrandWebApi.Data;
using Microsoft.AspNetCore.Authorization;
using SharedLibrary.Models;
using ErrandWebApi.Services;
using SharedLibrary.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace ErrandWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ServiceWorkersController : ControllerBase
    {
        private readonly SqlDbContext _context;
        private readonly IIdentityService _identity;
        private IConfiguration _configuration { get; }

        public ServiceWorkersController(SqlDbContext context, IIdentityService identity, IConfiguration configuration)
        {
            _context = context;
            _identity = identity;
            _configuration = configuration;
        }


        [AllowAnonymous]
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model)
        {
            if (await _identity.CreateServiceWorkerAsync(model))
                return new OkResult();

            return new BadRequestResult();
        }


        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LogIn([FromBody] LogInModel model)
        {
            try
            {
                var serviceworker = await _context.ServiceWorkers.FirstOrDefaultAsync(serviceworker => serviceworker.Email == model.Email);

                if (serviceworker != null)
                {
                    try
                    {
                        if (serviceworker.ValidatePasswordHash(model.Password))
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


                            return new OkObjectResult(_accessToken);
                        }
                    }
                    catch { }
                }
            }
            catch { }

            return new BadRequestResult();

        }
    







        // GET: api/ServiceWorkers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceWorker>>> GetServiceWorkers()
        {
            return await _context.ServiceWorkers.ToListAsync();
        }

        // GET: api/ServiceWorkers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceWorker>> GetServiceWorker(int id)
        {
            var serviceWorker = await _context.ServiceWorkers.FindAsync(id);

            if (serviceWorker == null)
            {
                return NotFound();
            }

            return serviceWorker;
        }


        // PUT: api/ServiceWorkers/5        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceWorker(int id, ServiceWorker serviceWorker)
        {
            if (id != serviceWorker.Id)
            {
                return BadRequest();
            }

            _context.Entry(serviceWorker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceWorkerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ServiceWorkers        
        [HttpPost]
        public async Task<ActionResult<ServiceWorker>> PostServiceWorker(ServiceWorker serviceWorker)
        {
            _context.ServiceWorkers.Add(serviceWorker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceWorker", new { id = serviceWorker.Id }, serviceWorker);
        }

        // DELETE: api/ServiceWorkers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceWorker(int id)
        {
            var serviceWorker = await _context.ServiceWorkers.FindAsync(id);
            if (serviceWorker == null)
            {
                return NotFound();
            }

            _context.ServiceWorkers.Remove(serviceWorker);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServiceWorkerExists(int id)
        {
            return _context.ServiceWorkers.Any(e => e.Id == id);
        }
    }
}
