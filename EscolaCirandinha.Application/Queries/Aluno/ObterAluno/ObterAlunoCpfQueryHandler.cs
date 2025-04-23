using AutoMapper;
using EscolaCirandinha.Application.DTOs.Response;
using EscolaCirandinha.Domain.Contracts.Repositories;
using MediatR;

namespace EscolaCirandinha.Application.Queries.Aluno.ObterAluno
{
    public class ObterAlunoCpfQueryHandler : IRequestHandler<ObterAlunoCpfQuery, AlunoResponse>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public ObterAlunoCpfQueryHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<AlunoResponse> Handle(ObterAlunoCpfQuery request, CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.ObtemAlunoCpf(request.Cpf);
            if (aluno == null)
            {
                return null;
            }
            return _mapper.Map<AlunoResponse>(aluno);
        }
    }
}