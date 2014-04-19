using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAutoMapper.Models;

namespace TestAutoMapper.App_Start {
    public class AutoMapperConfig {

        public static void RegisterMaps() {
            Mapper.CreateMap<Movie, BriefMovie>();
        }
    }
}