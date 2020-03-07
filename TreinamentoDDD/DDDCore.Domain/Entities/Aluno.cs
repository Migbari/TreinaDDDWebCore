using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCore.Domain.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Ativo { get; set; }
        public DateTime Datacadastro { get; set; }
        public IEnumerable<Materia> Materia { get; set; }
    }
}
