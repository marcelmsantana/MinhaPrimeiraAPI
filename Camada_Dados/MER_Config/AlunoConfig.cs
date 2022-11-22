using Camada_Dados.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camada_Dados.MER_Config
{
    public class AlunoConfig : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasOne(x => x.Professor)
                    .WithMany(x => x.Alunos);

            builder.HasOne(x => x.Escola)
                    .WithMany(x => x.Alunos);
        }
    }
}
