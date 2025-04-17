using EscolaCirandinha.Domain.Contracts.Repositories;
using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EscolaCirandinha.Infraestructure.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly ApplicationDbContext _context;

        public ProfessorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Professor?> ObtemProfessorCpf(string cpf)
        {
            return await _context.Professores.AsNoTracking().FirstOrDefaultAsync(p => p.DadosProfessor.Cpf == cpf);
        }

        public async Task<IEnumerable<Professor>?> ObtemProfessores()
        {
            return await _context.Professores.AsNoTracking().ToListAsync();
        }

        public async Task<Professor?> ObtemProfessorId(Guid id)
        {
            return await _context.Professores.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Professor>?> ObtemProfessorTurma(string turma)
        {
            return await _context.Professores.AsNoTracking().Where(t=>t.Turmas.Where(a=>a.Nome == turma)!= null).ToListAsync();
        }

        public async Task Adiciona(Professor professor)
        {
            var professorExistente = await ObtemProfessorCpf(professor.DadosProfessor.Cpf);
            if (professorExistente != null)
            {
                throw new Exception("Professor já cadastrado");
            }
            await _context.Professores.AddAsync(professor);
            await _context.SaveChangesAsync();
        }

        public async Task Atualiza(Professor professor)
        {
            var professorExistente = await ObtemProfessorId(professor.Id);
            if (professorExistente == null)
            {
                throw new Exception("Professor não encontrado");
            }
            _context.Professores.Update(professor);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Professor professor)
        {
            var professorExistente = await ObtemProfessorId(professor.Id);
            if (professorExistente == null)
            {
                throw new Exception("Professor não encontrado");
            }
            _context.Professores.Remove(professor);
            await _context.SaveChangesAsync();
        }
    }
}