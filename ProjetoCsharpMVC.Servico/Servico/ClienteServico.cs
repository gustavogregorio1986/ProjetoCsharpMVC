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
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void AdiocionarCliente(Cliente cliente)
        {
            _clienteRepositorio.AdicionarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
           return _clienteRepositorio.ListarClientes();
        }
    }
}
