using ProjetoCsharpMVC.Data.Contexto;
using ProjetoCsharpMVC.Data.Repositorio.Interface;
using ProjetoCsharpMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCsharpMVC.Data.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly BancoContexto _db;

        public FuncionarioRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _db.Set<Funcionario>().Add(funcionario);
            _db.SaveChanges();
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return _db.Set<Funcionario>().ToList();
        }
    }
}
