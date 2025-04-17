using EscolaCirandinha.Domain.Contracts.Repositories;
using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EscolaCirandinha.Infraestructure.Repositories
{
    public class CoordenadorRepository : ICoordenadorRepository
    {
        private readonly ApplicationDbContext _context;
        public CoordenadorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Coordenador>?> ObtemCoordenadores()
        {
            return await _context.Coordenadores.AsNoTracking().ToListAsync();
        }

        public async Task<Coordenador?> ObtemCoordenadorId(Guid id)
        {
            return await _context.Coordenadores.AsNoTracking().FirstOrDefaultAsync(a=>a.Id == id);
        }
        public async Task Adiciona(Coordenador coordenador)
        {
            var coordenadorExistente = await ObtemCoordenadorId(coordenador.Id);
            if(coordenadorExistente != null)
            {
                throw new Exception("Coordenador já existe");
            }
            await _context.Coordenadores.AddAsync(coordenador);
            await _context.SaveChangesAsync();
        }

        public async Task Atualiza(Coordenador coordenador)
        {
            var coordenadorExistente = await ObtemCoordenadorId(coordenador.Id);
            if (coordenadorExistente == null)
            {
                throw new Exception("Coordenador não existe");
            }
            _context.Entry(coordenadorExistente).CurrentValues.SetValues(coordenador);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Coordenador coordenador)
        {
            var coordenadorExistente = await ObtemCoordenadorId(coordenador.Id);
            if (coordenadorExistente == null)
            {
                throw new Exception("Coordenador não existe");
            }
            _context.Coordenadores.Remove(coordenadorExistente);
            await _context.SaveChangesAsync();
        }
    }
}