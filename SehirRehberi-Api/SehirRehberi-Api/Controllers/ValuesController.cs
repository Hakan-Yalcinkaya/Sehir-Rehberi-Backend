using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SehirRehberi_Api.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi_Api.Controllers
{
    
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        DataContext _dataContext;
        public ValuesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetValues()
        {
            var values =await _dataContext.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetValue(int id)
        {
            var value = await _dataContext.Values.FirstOrDefaultAsync(v=>v.Id==id);
            return Ok(value);
            }
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody]string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
        }
    }

