using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class MateriaConfiguration  : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        throw new NotImplementedException();
    }
}