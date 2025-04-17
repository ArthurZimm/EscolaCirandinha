using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class TurmaConfiguration  : IEntityTypeConfiguration<Turma>
{
    public void Configure(EntityTypeBuilder<Turma> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(t => t.Professor)
               .WithMany(p => p.Turmas)
               .HasForeignKey(t => t.ProfessorId);

        builder.HasMany(t => t.Alunos)
            .WithOne(a => a.Turma)
            .HasForeignKey(a => a.Id);

        builder.HasMany(t => t.Atividades)
            .WithOne(a => a.Turma)
            .HasForeignKey(a => a.TurmaId);
    }
}