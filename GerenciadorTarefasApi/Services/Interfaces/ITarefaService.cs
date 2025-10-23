using System;
using GerenciadorTarefasApi.Entities;

namespace GerenciadorTarefasApi.Services.Interfaces;

public interface ITarefaService
{
    List<Tarefas> ObterTodos();
    Tarefas? ObterPorId(int id);
    Tarefas Adicionar(Tarefas tarefaDto);
}
