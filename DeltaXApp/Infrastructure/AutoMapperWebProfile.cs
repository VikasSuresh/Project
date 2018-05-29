using DeltaX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeltaXApp.Infrastructure
{
    public class AutoMapperWebProfile:AutoMapper.Profile
    {
        public AutoMapperWebProfile()
        {
            CreateMap<Movy, Models.Movie>();
            CreateMap<Models.Movie, Movy>();
            CreateMap<Actor, Models.Actor>();
            CreateMap<Models.Actor, Actor>();
            CreateMap<Producer, Models.Producer>();
            CreateMap<Models.Producer, Producer>();

        }
        public static void Run()
        {
            AutoMapper.Mapper.Initialize(a =>
            {
                a.AddProfile<AutoMapperWebProfile>();
            });
        }
    }
}