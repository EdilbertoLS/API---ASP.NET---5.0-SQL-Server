using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    interface IPessoa 
    {

        Task<Pessoa> Create(Pessoa pessoa);
        Task<IEnumerable<Pessoa>> FindByID(long id);
        Task<IEnumerable<List<Pessoa>>> FindAll();
        Task<Pessoa> Update(Pessoa pessoa);
        void Delete(long id);


    }
}
