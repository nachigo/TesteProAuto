using System;
using TesteProAuto.Data;
using TesteProAuto.Domain.Busines;
using TesteProAuto.Domain.Repository;
using TesteProAuto.Repository;

namespace TesteProAuto.Busines
{
    public class AssociadoBll : IAssociadoBll
    {
        private IAssociadoRepository _associadoRepository;

        public AssociadoBll()
        {
            _associadoRepository = new AssociadoRepository();
        }

        public Associado GetAssociado(string cpf, string placa)
        {
            return _associadoRepository.GetAssociado(cpf, placa);
        }

        public Associado SaveEnderecoAssociado(string endereco, int idAssociado)
        {
            return _associadoRepository.SaveEnderecoAssociado(endereco, idAssociado);
        }
    }
}
