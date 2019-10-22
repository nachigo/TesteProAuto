using System;
using System.ComponentModel.DataAnnotations;

namespace TesteProAuto.Data
{
    public class Associado
    {
        [Key]
        public int IdAssociado { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Placa { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
