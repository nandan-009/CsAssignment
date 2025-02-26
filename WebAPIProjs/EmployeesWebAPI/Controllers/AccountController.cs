﻿using System.IdentityModel.Tokens.Jwt;
using System.Text;
using EmployeesWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace EmployeesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(UserDetails user)
        {
            //validate user database
            if (user.UserName == "admin" && user.Password == "admin")
            {
                //generate token
                var secretKey = "qwertyuiopasdfghjklzxcvbnm098765";
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

                var tokenParams = new JwtSecurityToken
                    (
                        issuer: "tavant",
                        audience:"tavant",
                        expires:DateTime.Now.AddMinutes(2),
                        signingCredentials: new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256)
                    );

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.WriteToken(tokenParams);

                return Ok(token);
            }
            else
            {
                return BadRequest("Invalid user credentials");
            }
        }
    }
}
