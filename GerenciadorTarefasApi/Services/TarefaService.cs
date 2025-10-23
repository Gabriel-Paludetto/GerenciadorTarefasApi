using System;
using AutoMapper;
using GerenciadorTarefasApi.Entities;
using GerenciadorTarefasApi.Infra.DTOs;
using GerenciadorTarefasApi.Infra.Repositories.Interfaces;
using GerenciadorTarefasApi.Services.Interfaces;

namespace GerenciadorTarefasApi.Services;

public class TarefaService : ITarefaService
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;
    public TarefaService(ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }
    public List<Tarefas> ObterTodos()
    {
        return _tarefaRepository.ObterTodos();
    }

    public Tarefas? ObterPorId(int id)
    {
        return _tarefaRepository.ObterPorId(id);
    }

    public Tarefas Adicionar(Tarefas tarefaDto)
    {
        return _tarefaRepository.Adicionar(tarefaDto);
    }
}
