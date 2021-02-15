using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Silva",
                Telefone = "1599118273"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Leo",
                Sobrenome = "Kent",
                Telefone = "1599118274"
            },
             new Aluno()
            {
                Id = 3,
                Nome = "Mu",
                Sobrenome = "Laura",
                Telefone = "1599118275"
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a =>
                a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
            );
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {

            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return Ok();
        }
    }
}
