using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuscaDadosCVM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxasimportadasController : ControllerBase
    {
        private readonly BuscaDadosCVMContext _context;

        public TaxasimportadasController(BuscaDadosCVMContext context)
        {
            _context = context;
        }

        // GET: api/<TaxasimportadasController>
        [HttpGet]
        public async Task<IEnumerable<Taxa>> ListAsync()
        {
            return await _context.Taxa.ToListAsync();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<TaxasimportadasController>/5
        [HttpGet("{cnpj}")]
        public async Task<Taxa> Get(string cnpj)
        {
            var result = await _context.Taxa.FindAsync(cnpj);
            return result;
            //return "value";
        }
        
        // GET api/<TaxasimportadasController>/2020-11-12&2018-10-04
        [HttpGet("{data}")]
        public async Task<Taxa> Get(DateTime DT_COMPTC)
        {
            var result = await _context.Taxa.FindAsync(DT_COMPTC);
            return result;
            //return "value";
        }

        // POST api/<TaxasimportadasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaxasimportadasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaxasimportadasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
