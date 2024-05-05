using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProjectWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _rolemanager;

        public AccountsController(RoleManager<IdentityRole> _rolemanager)
        {
            this._rolemanager = _rolemanager;
        }

        public IActionResult GetRoles()
        {
           var roles=  _rolemanager.Roles
                ;
            return Ok(roles);
        }
    }
}

