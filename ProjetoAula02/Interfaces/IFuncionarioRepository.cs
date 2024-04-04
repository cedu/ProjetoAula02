using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Interfaces
{
    /// <summary>
    /// Criando uma interface para abstração de repositório de funcionário
    /// </summary>
    public interface IFuncionarioRepository
    {
        #region Métodos Abstratos

        void Exportar(Funcionario funcionario);

        #endregion
    }
}
