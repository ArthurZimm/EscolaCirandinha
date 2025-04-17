using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class AlunoAtividadeConfiguration : IEntityTypeConfiguration<AlunoAtividade>
{
    public void Configure(EntityTypeBuilder<AlunoAtividade> builder)
    {
        builder.HasKey(aa => aa.Id);

        builder.HasOne(aa => aa.Aluno)
            .WithMany()
            .HasForeignKey(aa => aa.AlunoId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(aa => aa.Atividade)
            .WithMany()
            .HasForeignKey(aa => aa.AtividadeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(aa => aa.Nota)
            .IsRequired()
            .HasPrecision(5, 2);
    }
}