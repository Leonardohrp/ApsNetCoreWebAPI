﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina() { }

        public Disciplina(int id, string nome, int professorId, int cursoId)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorId;
            CursoId = cursoId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public int? PreRequisitoId { get; set; } = null;
        public Disciplina PreRequisito { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}
