

using AutoMapper;
using CRMZavet.BLL.DTO;
using CRMZavet.Models;
using System;
using System.Collections.Generic;

namespace CRMZavet.App_Start
{
    public  static class AutoMapperConfigWeb
    {
        public static readonly Action<IMapperConfigurationExpression> Config = cfg =>
        {
            cfg.CreateMap<DetailDTO, DetailVM>().ReverseMap();

        };
    }
}