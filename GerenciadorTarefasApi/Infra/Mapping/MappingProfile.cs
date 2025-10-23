using System;
using AutoMapper;
using GerenciadorTarefasApi.Entities;
using GerenciadorTarefasApi.Infra.DTOs;

namespace GerenciadorTarefasApi.Infra.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Tarefas, TarefaDetalhadaDto>();
        CreateMap<Tarefas, CriarTarefa>();
        CreateMap<Usuarios, UsuarioDto>();
    }
    
}
