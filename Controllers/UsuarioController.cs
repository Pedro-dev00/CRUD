using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHroa()
        {
            var obj = new
            {
                Data =  DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresenta/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Ola {nome} seja bem vindo";
            return Ok(new {mensagem});
        }
    }
}