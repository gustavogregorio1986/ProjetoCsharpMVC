using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCsharpMVC.Dominio.Dominio
{
    [Table("tb_Empresa")]
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        public string NomeEmoresa { get; set; }

        public string Setor { get; set; }

        public string Cnpj { get; set; }

        public Funcionario Funcionario { get; set; }

        [ForeignKey("Funcionario")]
        public int Id_Funcionario { get; set; }
    }
}
