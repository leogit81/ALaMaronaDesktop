﻿using ALaMarona.Core;
using ALaMarona.Domain.Entities;
using AutoMapper;
using ALaMarona.Domain.DTOs;

namespace ALaMarona.Core
{
    public class Factory: IFactory
    {
        private static readonly Factory _factory = new Factory();

        private Factory()
        {

        }

        public static Factory Instance
        {
            get
            {
                return _factory;
            }
        }

        public void ConfigureMapping()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Producto, ProductoDTO>().ReverseMap());
        }
    }
}