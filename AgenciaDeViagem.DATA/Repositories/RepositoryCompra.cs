using AgenciaDeViagem.DATA.Interfaces;
using AgenciaDeViagem.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViagem.DATA.Repositories
{
    public class RepositoryCompra : RepositoryBase<Compra>, IRepositoryCompra
    {
        public RepositoryCompra(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
