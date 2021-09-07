using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    interface IPessoa
    {

        IEnumerable<Pessoa> Create(Pessoa pessoa);
        IEnumerable<Pessoa> FindByID(long id);
        IEnumerable<List<Pessoa>> FindAll();
        IEnumerable<Pessoa> Update(Pessoa pessoa);
        void Delete(long id);


    }
}
