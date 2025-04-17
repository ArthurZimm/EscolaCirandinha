using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class ProfessorConfiguration  : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        builder.HasKey(p => p.Id);

        builder.OwnsOne(p => p.DadosProfessor, dp =>
        {
            dp.Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(100);

            dp.Property(d => d.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            dp.Property(d => d.DataNascimento)
                .IsRequired();
        });

        builder.Property(p => p.Senha)
            .IsRequired()
            .HasMaxLength(100); 

        builder.HasMany(p => p.Turmas)
            .WithOne(t => t.Professor)
            .HasForeignKey(t => t.ProfessorId);

        builder.HasMany(p => p.ProfessorMaterias)
               .WithOne(pm => pm.Professor)
               .HasForeignKey(pm => pm.ProfessorId);
    }
}