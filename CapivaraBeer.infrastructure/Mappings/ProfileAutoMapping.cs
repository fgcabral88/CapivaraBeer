using AutoMapper;
using CapivaraBeer.Domain.Entities;
using CapivaraBeer.Application.Dtos.Cursos;

namespace CapivaraBeer.infrastructure.Mappings
{
    public class ProfileAutoMapping : Profile
    {
        public ProfileAutoMapping()
        {
            // Usuários
            CreateMap<Cursos, CursosCriarDto>().ReverseMap();
            CreateMap<Cursos, CursosEditarDto>().ReverseMap();
            CreateMap<Cursos, CursosListarDto>().ReverseMap();

            // Dtos
            CreateMap<CursosCriarDto, CursosListarDto>().ReverseMap();
            CreateMap<CursosEditarDto, CursosListarDto>().ReverseMap();
        }
    }
}
