using AgenciaDeViagem.DATA.Interfaces;
using AgenciaDeViagem.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViagem.DATA.Repositories
{
    public class RepositoryPessoas : RepositoryBase<Pessoas>, IRepositoryPessoas
    {
        public RepositoryPessoas(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
