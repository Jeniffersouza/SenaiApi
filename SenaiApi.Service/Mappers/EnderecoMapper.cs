using AutoMapper;
using SenaiApi.Domain.Dtos;
using SenaiApi.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Mappers
{
    public class EnderecoMapper : Profile
    {

        public EnderecoMapper() {

            CreateMap<EnderecoDto, Endereco>();
        
        }
    }
}
