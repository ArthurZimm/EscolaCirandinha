using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class ProfessorMateriaConfiguration  : IEntityTypeConfiguration<ProfessorMateria>
{
    public void Configure(EntityTypeBuilder<ProfessorMateria> builder)
    {
        throw new NotImplementedException();
    }
}