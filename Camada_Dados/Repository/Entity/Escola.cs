using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Camada_Dados.Repository.Entity
{
    public class Escola
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Aluno> Alunos { get; set; }

    }
}
