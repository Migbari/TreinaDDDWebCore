using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCore.Domain.Entities.Associative
{
    public class AlunoMateria
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int MateriaId { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Materia Materia { get; set; }
        public string MesAno { get; set; }
        public decimal Nota { get; set; }
    }
}
