using System;
using System.Collections.Generic;
using System.Text;
using TesteProAuto.Data;

namespace TesteProAuto.Domain.Busines
{
    public interface IAssociadoBll
    {
        Associado GetAssociado(string cpf, string placa);
        Associado SaveEnderecoAssociado(string endereco, int idAssociado);
    }
}
