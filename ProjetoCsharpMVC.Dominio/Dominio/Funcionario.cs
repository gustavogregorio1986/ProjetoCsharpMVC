using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCsharpMVC.Dominio.Dominio
{
    [Table("tb_Funcionario")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuncionario { get; set; }

        public string NomeFuncionario { get; set; }

        public string EmailFuncionario { get; set; }

        public string Cargo { get; set; }

        public decimal Salario { get; set; }

        public string Cpf { get; set; }
    }
}
