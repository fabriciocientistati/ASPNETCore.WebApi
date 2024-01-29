using ASPNETCore.WebApi.Interfaces;
using ASPNETCore.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _IlunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _IlunoRepository = alunoRepository;
        }

        [Authorize]
        [HttpGet("Selecionar todos Alunos")]
        public async Task<ActionResult<IEnumerable<Tbaluno>>> GetAluno()
        {
            return Ok(await _IlunoRepository.SelectAll());
        }

        [Authorize]
        [HttpGet("Buscar Aluno")]
        public async Task<ActionResult> SelectAluno(int id)
        {
            var aluno = await _IlunoRepository.SelectByPk(id);

            if (aluno == null)
            {
                return NotFound("Aluno não se encontra em nossa base de dados.");
            }
            return Ok(aluno);
        }

        [Authorize]
        [HttpPost("Criar Aluno")]
        public IActionResult Create([FromBody] Tbaluno aluno)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _IlunoRepository.Create(aluno);
            return Ok(aluno);
        }

        [Authorize]
        [HttpPut("Atualizar Aluno")]
        public async Task<IActionResult> Update(int id, [FromBody] Tbaluno aluno)
        {
            var existeAluno = await _IlunoRepository.SelectByPk(id);

            if (existeAluno.AluId != id)
                return NotFound("Aluno não encontrado");

                existeAluno.AluNom = aluno.AluNom;
                existeAluno.AluCpf = aluno.AluCpf;
                existeAluno.AluDtaNasc = aluno.AluDtaNasc;
                existeAluno.AluAltEm = DateTime.Now;

            try
            {
                _IlunoRepository.Update(aluno);
                await _IlunoRepository.SaveAllAsync();
                    return Ok("Atualizado com sucesso");
            }
            catch
            {
                return StatusCode(500, "Erro interno do servidor");
            }
        }

        [Authorize]
        [HttpDelete("Apagar um Aluno")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            _IlunoRepository.Delete(id);
            return Ok("Aluno apagado com sucesso!");
        }
    }
}
