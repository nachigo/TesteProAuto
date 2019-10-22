using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteProAuto.Busines;
using TesteProAuto.Domain.BO;
using TesteProAuto.Domain.Busines;

namespace TesteProAuto.WebApi.Controllers
{
    public class AssociadoController : Controller
    {
        private IAssociadoBll _associadoBll;

        public AssociadoController()
        {
            _associadoBll = new AssociadoBll();
        }

        /// <summary>
        /// Retorna o Associado pelo cpf e placa enviados
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="placa"></param>
        /// <returns>Associado</returns>
        [HttpGet("{cpf}/{placa}")]
        public IActionResult GetAssociado(string cpf, string placa)
        {
            try
            {
                return Json(_associadoBll.GetAssociado(cpf, placa));
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu o seguinte erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Salva o endereco do Associado
        /// </summary>
        /// <param name="objRequest"></param>
        /// <returns>Associado</returns>
        [HttpPut("Endereco")]
        public IActionResult SaveEnderecoAssociado([FromBody]SaveEnderecoAssociadoRequestBO objRequest)
        {
            try
            {
                return Json(_associadoBll.SaveEnderecoAssociado(objRequest.Endereco, objRequest.IdAssociado));
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu o seguinte erro: {ex.Message}");
            }
        }
    }
}