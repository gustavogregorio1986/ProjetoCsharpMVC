using ProjetoCsharpMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCsharpMVC.Data.Repositorio.Interface
{
    public interface IFuncionarioRepositorio
    {
        void AdicionarFuncionario(Funcionario funcionario);

        List<Funcionario> ListarFuncionarios();
    }
}
