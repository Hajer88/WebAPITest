using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProjectWebAPI.Models;
using FirstProjectWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProjectWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var c = await categoryService.GetAll();
            return Ok(c);
        }
      /*  [HttpGet]
        public IActionResult TestStaticData()
        {
            var test = categoryService.GetAllTest();
            return Ok(test);
        }*/

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

