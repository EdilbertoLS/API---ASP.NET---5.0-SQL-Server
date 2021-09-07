
using API.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Imp
{
    class PessoaImplement : IPessoa { 

        private readonly AppContext _context;

        public PessoaImplement(AppContext context)
        {
            _context = context;

        }


        IEnumerable<Pessoa> IPessoa.Create(Pessoa pessoa)
        {
            throw new System.NotImplementedException();
        }

        void IPessoa.Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<List<Pessoa>> IPessoa.FindAll()
        {
            throw new System.NotImplementedException();

        }

        IEnumerable<Pessoa> IPessoa.FindByID(long id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Pessoa> IPessoa.Update(Pessoa pessoa)
        {
            throw new System.NotImplementedException();
        }
    }
}
