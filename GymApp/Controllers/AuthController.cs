using GymApp.Data;
using GymApp.Models;
using GymApp.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly GymAppDBContext _context;

        public AuthController(GymAppDBContext context)
        {
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login([FromBody] LoginDTO loginDTO)
        {
            if(loginDTO == null) 
            {
                return BadRequest("Invalid Client request");
            }
            
            var user = await _context.User.Where(user =>
            user.UserName.ToLower()== loginDTO.Username.ToLower()).FirstOrDefaultAsync();

            if(user == null)
            {
                NotFound("User Not Found");
            }

            if(loginDTO.Username.ToLower() == user.UserName.ToLower() && loginDTO.Password == user.Password)
            {
                return Ok(user);
            }
            else
            {
                return Unauthorized("Unauthorized access");
            }
        }
    }
}
