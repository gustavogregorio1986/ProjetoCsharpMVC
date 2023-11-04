using ProjetoCsharpMVC.Data.Repositorio.Interface;
using ProjetoCsharpMVC.Dominio.Dominio;
using ProjetoCsharpMVC.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCsharpMVC.Servico.Servico
{
    public class FuncionarioServico : IFuncionarioServico
    {
        private readonly IFuncionarioRepositorio _funcioanrioRepositorio;

        public FuncionarioServico(IFuncionarioRepositorio funcioanrioRepositorio)
        {
            _funcioanrioRepositorio = funcioanrioRepositorio;
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _funcioanrioRepositorio.AdicionarFuncionario(funcionario);
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return _funcioanrioRepositorio.ListarFuncionarios();
        }
    }
}
