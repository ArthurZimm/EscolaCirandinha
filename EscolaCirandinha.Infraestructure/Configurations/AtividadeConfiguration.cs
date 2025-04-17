using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class AtividadeConfiguration : IEntityTypeConfiguration<Atividade>
{
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Avaliacao)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.NotaMaxima)
            .IsRequired()
            .HasColumnType("decimal(5,2)");

        builder.HasOne(a => a.Turma)
            .WithMany(t => t.Atividades)
            .HasForeignKey(a => a.TurmaId)
            .IsRequired();

        builder.HasMany(a => a.AlunoAtividades)
            .WithOne(aa => aa.Atividade)
            .HasForeignKey(aa => aa.AtividadeId);
    }
}