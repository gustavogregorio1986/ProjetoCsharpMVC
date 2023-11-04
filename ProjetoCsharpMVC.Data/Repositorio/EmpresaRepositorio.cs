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
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly BancoContexto _db;

        public EmpresaRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void AdicionarEmoresa(Empresa empresa)
        {
            _db.Set<Empresa>().Add(empresa);
            _db.SaveChanges();

        }

        public List<Empresa> ListarEmpresas()
        {
            return _db.Set<Empresa>().ToList();
        }
    }
}
