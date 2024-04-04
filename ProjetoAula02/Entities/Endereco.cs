using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Entities
{
    public class Endereco
    {
        /// <summary>
        /// Modelo de Entidade Endereço
        /// </summary>
        public Guid IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

    }
}
