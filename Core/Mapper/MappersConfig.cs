using AutoMapper;
using Core.Dtos;
using Core.Entities;

namespace Core.Mapper
{
    public class MappersConfig : Profile
    {
        public MappersConfig()
        {
            CreateMap<Cliente, ClienteDto>()
                .ForMember(dest => dest.apellido ,opt => opt.MapFrom(src => src.apellidos))
                .ForMember(dest => dest.nombre ,opt => opt.MapFrom(src => src.nombres))
                .ForMember(dest => dest.MotivoDto ,opt => opt.MapFrom(src => src.idMotivoNavigator))
                .ReverseMap();

            CreateMap<Motivo, MotivoDto>()
            .ForMember(dest => dest.nombre, opt => opt.MapFrom(src => src.nombreMotivo))
            .ReverseMap();
        }
    }
}
