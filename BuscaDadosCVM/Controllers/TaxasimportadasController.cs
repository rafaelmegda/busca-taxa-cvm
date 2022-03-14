using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Taxa))]
        public async Task<ActionResult<IEnumerable<Taxa>>> ListAsync()
        {
            var result = await _context.Taxa.ToListAsync();
            return Ok(result);
        }

        // GET api/<TaxasimportadasController>/00819915000123/2020-10-01/2020-10-08
        [HttpGet("{CNPJ_FUNDO}/{data_inicial:regex(\\d{{4}}-\\d{{2}}-\\d{{2}})?}/{data_final:regex(\\d{{4}}-\\d{{2}}-\\d{{2}})?}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Taxa))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Taxa>>> Get(string CNPJ_FUNDO, DateTime data_inicial, DateTime data_final)
        {
            try
            {
                CNPJ_FUNDO = Convert.ToUInt64(CNPJ_FUNDO).ToString(@"00\.000\.000\/0000\-00");

                if (data_inicial == DateTime.MinValue && data_final == DateTime.MinValue)
                {
                    var resultadoSemData = _context.Taxa.ToArray()
                        .Where(m => m.CNPJ_FUNDO == CNPJ_FUNDO).ToList();

                    return Ok(resultadoSemData);
                }
                else if(data_inicial == DateTime.MinValue || data_final == DateTime.MinValue)
                {
                    return BadRequest("Não é possível realizar a busca usando somente um campo data, informe /<cnpj>/<data_inicial>/<data_final>");
                }

                var resultado = _context.Taxa.ToArray().Where(m => m.CNPJ_FUNDO == CNPJ_FUNDO)
                    .Where(x => x.DT_COMPTC >= data_inicial)
                    .Where(x => x.DT_COMPTC <= data_final).ToList();

                return Ok(resultado);
            }
            catch (FormatException fe)
            {
                return BadRequest("CNPJ Inesistente ou no formato incorreto");
                throw;
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                throw;
            }



        }

        //// POST api/<TaxasimportadasController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{

        //}

        //// PUT api/<TaxasimportadasController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TaxasimportadasController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
