using ProjetoAula02.Entities;
using ProjetoAula02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Controllers
{
    /// <summary>
    /// Controlador para realização de fluxos de funcionário.
    /// </summary>
    public class FuncionarioController
    {
        /// <summary>
        /// Método para realização do fluxo de funcionário
        /// </summary>
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n*** CADASTRO DE FUNCIONÁRIOS: ***\n");
                var funcionario = new Funcionario()
                {
                    IdFuncionario = Guid.NewGuid(), //gerando um Id aleatório
                    Endereco = new Endereco() //instanciando Endereço
                    {
                        IdEndereco = Guid.NewGuid(),
                    }
                };

                Console.Write("INFORME O NOME DO FUNCIONÁRIO..: ");
                funcionario.Nome = Console.ReadLine();
                
                Console.Write("INFORME O CPF DO FUNCIONÁRIO..: ");
                funcionario.Cpf = Console.ReadLine();
                
                Console.Write("INFORME A MATRÍCULA DO FUNCIONÁRIO..: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("INFORME A DATA DE ADMISSÃO DO FUNCIONÁRIO..: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("INFORME O SALÁRIO DO FUNCIONÁRIO..: ");
                funcionario.Salario = decimal.Parse(Console.ReadLine());

                Console.Write("INFORME O LOGRADOURO DO FUNCIONÁRIO..: ");
                funcionario.Endereco.Logradouro = Console.ReadLine();
                
                Console.Write("INFORME O COMPLEMENTO DO FUNCIONÁRIO..: ");
                funcionario.Endereco.Complemento = Console.ReadLine();

                Console.Write("INFORME O NÚMERO DO FUNCIONÁRIO..: ");
                funcionario.Endereco.Numero = Console.ReadLine();
                
                Console.Write("INFORME O BAIRRO DO FUNCIONÁRIO..: ");
                funcionario.Endereco.Bairro = Console.ReadLine();
                
                Console.Write("INFORME O LOCALIDADE DO FUNCIONÁRIO..: ");
                funcionario.Endereco.Localidade = Console.ReadLine();

                Console.Write("INFORME O UF DO FUNCIONÁRIO..: ");
                funcionario.Endereco.Uf = Console.ReadLine();

                Console.Write("INFORME O CEP DO FUNCIONÁRIO..: ");
                funcionario.Endereco.Cep = Console.ReadLine();

                var funcionarioRepositoryXml = new FuncionarioRepositoryXml();
                funcionarioRepositoryXml.Exportar(funcionario);

                Console.WriteLine("FUNCIONÁRIO CADASTRADO COM SUCESSO!");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao cadastrar funcionário: {e.Message}.");
            }
        }
    }
}
