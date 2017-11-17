using AutoMapper;
using CRMZavet.BLL.DTO;
using CRMZavet.DAL.Entities;
using System;

namespace CRMZavet.BLL.Infrastructure
{
    public static class AutmapperConfigBLL
    {
        public static readonly Action<IMapperConfigurationExpression> Configure = cfg =>
        {
            cfg.CreateMap<AppPaste, AppPasteDTO>().ReverseMap();
        };
    }
}
