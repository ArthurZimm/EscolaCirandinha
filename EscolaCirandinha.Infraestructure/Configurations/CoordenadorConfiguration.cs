using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class CoordenadorConfiguration  : IEntityTypeConfiguration<Coordenador>
{
    public void Configure(EntityTypeBuilder<Coordenador> builder)
    {
        throw new NotImplementedException();
    }
}