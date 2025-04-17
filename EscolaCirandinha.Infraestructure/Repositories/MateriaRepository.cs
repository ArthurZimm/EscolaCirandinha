using EscolaCirandinha.Domain.Contracts.Repositories;
using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EscolaCirandinha.Infraestructure.Repositories
{
    public class MateriaRepository : IMateriaRepository
    {
        private readonly ApplicationDbContext _context;

        public MateriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Materia?> ObtemMateriaId(Guid id)
        {
            return await _context.Materias.AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Materia>?> ObtemMaterias()
        {
            return await _context.Materias.AsNoTracking()
                .ToListAsync();
        }

        public async Task Adiciona(Materia materia)
        {
            var materiaExistente = await ObtemMateriaId(materia.Id);
            if (materiaExistente != null)
            {
                throw new Exception("Materia já existe");
            }
            await _context.Materias.AddAsync(materia);
            await _context.SaveChangesAsync();
        }

        public async Task Atualiza(Materia materia)
        {
            var materiaExistente = await ObtemMateriaId(materia.Id);
            if (materiaExistente == null)
            {
                throw new Exception("Materia não existe");
            }
            _context.Entry(materiaExistente).CurrentValues.SetValues(materia);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Materia materia)
        {
            var materiaExistente = await ObtemMateriaId(materia.Id);
            if (materiaExistente == null)
            {
                throw new Exception("Materia não existe");
            }
            _context.Materias.Remove(materiaExistente);
            await _context.SaveChangesAsync();
        }
    }
}