using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Entities
{
    /// <summary>
    /// Modelo de Entidade Funcionário
    /// </summary>
    public class Funcionario
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }

        #region Relacionamentos

        public Endereco Endereco { get; set; }

        #endregion
    }
}
