using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ErrandWebApi.Data;
using SharedLibrary.Entities;
using ErrandWebApi.Services;
using SharedLibrary.Models;
using Microsoft.AspNetCore.Authorization;

namespace ErrandWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ErrandsController : ControllerBase
    {
        private readonly SqlDbContext _context;
        private readonly IIdentityService _identity;

        public ErrandsController(SqlDbContext context, IIdentityService identity)
        {
            _context = context;
            _identity = identity;
        }



        // GET: api/Errands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Errand>>> GetErrands()
        {
            return await _context.Errands.ToListAsync();
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateErrand([FromBody] CreateErrandModel model)
        {
            if (await _identity.CreateErrandAsync(model))
                return new OkResult();

            return new BadRequestResult();
        }

        [HttpGet("searchstatus/{status}")]
        public async Task<ActionResult<Errand>> SearchStatus(string status)
        {
            try
            {
                var result = await _identity.SearchStatusAsync(status);

                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpGet("searchcustomer/{customername}")]
        public async Task<ActionResult<Errand>> SearchCustomer(string customername)
        {
            try
            {
                var result = await _identity.SearchCustomerAsync(customername);

                if (result.Any())
                {
                    return Ok(result);
                }                

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpGet("searchcreateddate/{createddate}")]
        public async Task<ActionResult<Errand>> SearchCreatedDate(string createddate)
        {
            try
            {
                var result = await _identity.SearchCreatedDateAsync(createddate);

                return Ok(result);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }



        // GET: api/Errands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Errand>> GetErrand(int id)
        {
            var errand = await _context.Errands.FindAsync(id);

            if (errand == null)
            {
                return NotFound();
            }

            return errand;
        }




        // PUT: api/Errands/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutErrand(int id, EditErrandModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            var errand = await _context.Errands.FindAsync(id);
            errand.ServiceWorkerId = model.ServiceWorkerId;
            errand.CustomerName = model.CustomerName;
            errand.Description = model.Description;
            errand.Status = model.Status;

            if (model.Status.Contains("Completed"))
            {
                errand.Changed = DateTime.Now;
            }                
            else
                model.Changed = null;

            _context.Entry(errand).State = EntityState.Modified;
            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ErrandExists(id))
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

        

        // DELETE: api/Errands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteErrand(int id)
        {
            var errand = await _context.Errands.FindAsync(id);
            if (errand == null)
            {
                return NotFound();
            }

            _context.Errands.Remove(errand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ErrandExists(int id)
        {
            return _context.Errands.Any(e => e.Id == id);
        }
    }
}
