using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class MateriaConfiguration  : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(m => m.ProfessorMaterias)
                .WithOne(pm => pm.Materia)
                .HasForeignKey(pm => pm.MateriaId);
    }
}