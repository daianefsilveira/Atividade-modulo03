using AgenciaDeViagem.DATA.Interfaces;
using AgenciaDeViagem.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViagem.DATA.Repositories
{
    public class RepositoryPassagens : RepositoryBase<Passagens>, IRepositoryPassagens
    {
        public RepositoryPassagens(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
