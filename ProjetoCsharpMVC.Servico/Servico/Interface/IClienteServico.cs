using ProjetoCsharpMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCsharpMVC.Servico.Servico.Interface
{
    public interface IClienteServico
    {
        void AdiocionarCliente(Cliente cliente);

        List<Cliente> ListarClientes();
    }
}
