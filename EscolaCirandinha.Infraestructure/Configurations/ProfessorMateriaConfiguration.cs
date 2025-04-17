using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class ProfessorMateriaConfiguration  : IEntityTypeConfiguration<ProfessorMateria>
{
    public void Configure(EntityTypeBuilder<ProfessorMateria> builder)
    {
        builder.HasKey(pm => pm.Id);

        builder.HasOne(pm => pm.Professor)
               .WithMany(p => p.ProfessorMaterias)
               .HasForeignKey(pm => pm.ProfessorId);

        builder.HasOne(pm => pm.Materia)
               .WithMany(m => m.ProfessorMaterias)
               .HasForeignKey(pm => pm.MateriaId);
    }
}