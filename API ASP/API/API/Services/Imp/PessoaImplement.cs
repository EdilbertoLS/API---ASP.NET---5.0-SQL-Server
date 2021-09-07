
using API.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Imp
{
    class PessoaImplement : IPessoa
    {

        private readonly AppContext _context;

        public PessoaImplement(AppContext context)
        {
            _context = context;

        }

        async Task<Pessoa> IPessoa.Create(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();
            return pessoa;
        }

        void IPessoa.Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<List<Pessoa>>> IPessoa.FindAll()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Pessoa>> IPessoa.FindByID(long id)
        {
            throw new System.NotImplementedException();
        }

        Task<Pessoa> IPessoa.Update(Pessoa pessoa)
        {
            throw new System.NotImplementedException();
        }
    }
}
