using AutoMapper;
using robodoc.backend.Controllers.DTO;
using Robodoc.Data.Models;

namespace robodoc.backend.Common.Mapper
{
    public class MedikamentMapper : Profile
    {
        public MedikamentMapper()
        {
            CreateMap<MedikamentDTO, Medikament>()
                .ForMember(dest => dest.Verabreichungsprozess, opt => opt.Ignore())
                .ForMember(dest => dest.Einheit,
                    opt => opt.MapFrom(
                        src => (Einheiten)Enum.Parse<Einheiten>(src.Einheit)));

            CreateMap<Medikament, MedikamentDTO>()
                .ForMember(dest => dest.Verabreichungsprozess,
                    opt => opt.MapFrom(src => src.Verabreichungsprozess.Name));
        }
    }
}