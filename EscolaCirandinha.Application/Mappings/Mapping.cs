using AutoMapper;

namespace EscolaCirandinha.Application.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Domain.Entities.Aluno, DTOs.AlunoDto>().ReverseMap();
            CreateMap<Domain.Entities.Professor, DTOs.ProfessorDto>().ReverseMap();
            CreateMap<Domain.Entities.Coordenador, DTOs.CoordenadorDto>().ReverseMap();
            CreateMap<Domain.Entities.Atividade, DTOs.AtividadeDto>().ReverseMap();
        }
    }
}