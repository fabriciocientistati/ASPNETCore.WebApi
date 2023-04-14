using ASPNETCore.WebApi.Interfaces;
using ASPNETCore.WebApi.Models;
using ASPNETCore.WebApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
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
        [HttpGet("selecionarTodos")]
        public async Task<ActionResult<IEnumerable<Tbaluno>>> GetAluno()
        {
            return Ok(await _IlunoRepository.SelectAll());
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult> SelectAluno(int id)
        {
            var aluno = await _IlunoRepository.SelectByPk(id);

            if (aluno == null)
            {
                return NotFound("Aluno não se encontra em nossa base de dados.");
            }

            return Ok(aluno);
        }
    }
}
