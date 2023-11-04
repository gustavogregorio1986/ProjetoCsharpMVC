﻿using ProjetoCsharpMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCsharpMVC.Servico.Servico.Interface
{
    public interface IEmpresaServico
    {
        void AdicionarEmpresa(Empresa empresa);

        List<Empresa> ListarEmpresas();
    }
}