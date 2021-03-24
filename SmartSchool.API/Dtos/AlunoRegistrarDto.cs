using System;

namespace SmartSchool.API.Dtos
{
    /// <summary>
    /// Este é o DTO de Aluno para Registrar.
    /// </summary>
    public class AlunoRegistrarDto
    {
        /// <summary>
        /// Identificar a chave do Banco.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Chave do Aluno, para outros negócios e na Instituição.
        /// </summary>
        public int Matricula { get; set; }

        /// <summary>
        /// Nome é o Primeiro nome.
        /// </summary>
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;


        public DateTime? DataFim { get; set; } = null;
        public bool Ativo { get; set; } = true;
    }
}
