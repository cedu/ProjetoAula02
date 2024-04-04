using ProjetoAula02.Entities;
using ProjetoAula02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula02.Repositories
{
    public class FuncionarioRepositoryXml : IFuncionarioRepository
    {
        /// <summary>
        /// Classe para implementação do repositório de funcionário para tipo XML. 
        /// </summary>
        public void Exportar(Funcionario funcionario)
        {
            //serializar os dados do funcionário para o formato XML
            var xmlSerializer = new XmlSerializer(typeof(Funcionario));

            //abrir um arquivo em modo de escrita
            var streamWriter = new StreamWriter($"C:\\Users\\Carlos Eduardo\\source\\repos\\Turma-SQS-2024\\ProjetoAula02\\Arquivos\\funcionario_{funcionario.IdFuncionario}.xml");

            //escrever os dados do funcionário no arquivo
            xmlSerializer.Serialize(streamWriter, funcionario);

            //fechar o arquivo
            streamWriter.Close();
        }
    }
}
