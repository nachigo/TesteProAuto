using System;
using System.Collections.Generic;
using System.Text;
using TesteProAuto.Data;

namespace TesteProAuto.Domain.Repository
{
    public interface IAssociadoRepository
    {
        Associado GetAssociado(string cpf, string placa);
        Associado SaveEnderecoAssociado(string endereco, int idAssociado);
    }
}
