using API.Context;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PessoaController : Controller
    {

        private readonly AppContext _context;


        public PessoaController(AppContext context)
        {
            _context = context;
        }



        // GET: api/pessoa  - Todas as pessoas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoas()
        {
            return await _context.Pessoas.ToListAsync();
        }

        //GET: api/pessoa/id - Retorna uma pessoa com um ID
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoa(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return Ok(pessoa);
        }

        //POST - ALOCA UMA NOVA PESSOA NO BANCO
        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetMovie", new { id = pessoa.Id }, pessoa);

        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Pessoa>> PutPessoa(int id, Pessoa pessoa)
        {
            if (!PessoaExiste(id))
            {
                return BadRequest();
            }

            _context.Entry(pessoa).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExiste(id))
                {
                    return NotFound();
                }
                else{
                    throw;
                }

            }
            return NoContent();

        }

        



        [HttpDelete("{id}")]
        public async Task<ActionResult<Pessoa>> DeletePessoa(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);
            
            if (pessoa == null)
            {
                return NotFound();
            }

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();

            return pessoa;
        }

        private bool PessoaExiste(int id)
        {
            return _context.Pessoas.Any(e => e.Id == id);
        }







    }
}
