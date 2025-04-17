using EscolaCirandinha.Domain.Contracts.Repositories;
using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EscolaCirandinha.Infraestructure.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly ApplicationDbContext _context;

        public AlunoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Aluno?> ObtemAlunoCpf(string cpf)
        {
            return await _context.Alunos.AsNoTracking().FirstOrDefaultAsync(a => a.DadosAluno.Cpf == cpf);
        }

        public async Task<Aluno?> ObtemAlunoId(Guid id)
        {
            return await _context.Alunos.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Aluno>?> ObtemAlunosTurma(Guid turmaId)
        {
            return await _context.Alunos.AsNoTracking().Where(a => a.TurmaId == turmaId).ToListAsync();
        }

        public async Task Adiciona(Aluno aluno)
        {
            var alunoExistente = await ObtemAlunoId(aluno.Id);
            if (alunoExistente != null)
            {
                throw new Exception("Já existe um aluno cadastrado com esse CPF.");
            }
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task Atualiza(Aluno aluno)
        {
            var alunoExistente = await ObtemAlunoId(aluno.Id);
            if (alunoExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }
            _context.Entry(aluno).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Aluno aluno)
        {
            var alunoExistente = await ObtemAlunoId(aluno.Id);
            if (alunoExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }
            _context.Alunos.Remove(alunoExistente);
            await _context.SaveChangesAsync();
        }
    }
}
