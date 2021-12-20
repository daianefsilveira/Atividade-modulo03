using AgenciaDeViagem.DATA.Interfaces;
using AgenciaDeViagem.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViagem.DATA.Repositories
{
    public class RepositoryAgencia : RepositoryBase<Agencia>, IRepositoryAgencia
    {
        public RepositoryAgencia(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
