using AgenciaDeViagem.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViagem.DATA.Services
{
    public class PessoasServices
    {
        public RepositoryPessoas oRepositoryPessoas { get; set; }

        public PessoasServices()
        {
            oRepositoryPessoas = new RepositoryPessoas();
        }


    }   
}
