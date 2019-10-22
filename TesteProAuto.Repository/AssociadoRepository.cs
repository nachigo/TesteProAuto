using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TesteProAuto.Data;
using TesteProAuto.Domain.Repository;

namespace TesteProAuto.Repository
{
    public class AssociadoRepository : IAssociadoRepository
    {
        public Associado GetAssociado(string cpf, string placa)
        {
            var result = new Associado();
            using (var context = new TesteProAutoContext())
            {
                try
                {
                    result = context.Associado.Where(a => a.Cpf == cpf && a.Placa == placa).First();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public Associado SaveEnderecoAssociado(string endereco, int idAssociado)
        {
            var result = new Associado();
            using (var context = new TesteProAutoContext())
            {
                try
                {
                    result = context.Associado.Find(idAssociado);

                    if (result != null)
                    {
                        result.Endereco = endereco;
                        context.Entry(result).State = EntityState.Modified;

                        var ret = context.SaveChanges();

                        if(ret == 0)
                        {
                            throw new Exception("Não foi salvo!");
                        }
                    }
                    else
                    {
                        throw new Exception("Não foi encontrado!");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }
    }
}
