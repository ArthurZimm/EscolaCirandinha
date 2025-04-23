using AutoMapper;
using EscolaCirandinha.Application.DTOs.Response;

namespace EscolaCirandinha.Application.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            //Mapeamento de entidades para response
            CreateMap<Domain.Entities.Aluno, AlunoResponse>();
            CreateMap<Domain.Entities.Professor, ProfessorResponse>();
            CreateMap<Domain.Entities.Coordenador, CoordenadorResponse>();
            CreateMap<Domain.Entities.Atividade, AtividadeResponse>();
            CreateMap<Domain.Entities.Turma, TurmaResponse>();

            //- Mapeamento de ValueObjects da response
            CreateMap<Domain.Shared.ValueObjects.Endereco, EnderecoResponse>();
            CreateMap<Domain.Shared.ValueObjects.DadosPessoais, DadosPessoaisResponse>();
        }
    }
}