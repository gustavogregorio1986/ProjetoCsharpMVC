using ProjetoCsharpMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCsharpMVC.Data.Repositorio.Interface
{
    public interface IEmpresaRepositorio
    {
        void AdicionarEmoresa(Empresa empresa);

        List<Empresa> ListarEmpresas();
    }
}
