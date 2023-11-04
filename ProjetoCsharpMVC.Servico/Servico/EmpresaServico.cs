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
    public class EmpresaServico : IEmpresaServico
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaServico(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        public void AdicionarEmpresa(Empresa empresa)
        {
            _empresaRepositorio.AdicionarEmoresa(empresa);
        }

        public List<Empresa> ListarEmpresas()
        {
           return _empresaRepositorio.ListarEmpresas();
        }
    }
}
