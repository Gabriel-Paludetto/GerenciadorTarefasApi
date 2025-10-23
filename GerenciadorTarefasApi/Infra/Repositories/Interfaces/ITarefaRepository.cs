using System;
using GerenciadorTarefasApi.Entities;

namespace GerenciadorTarefasApi.Infra.Repositories.Interfaces;

public interface ITarefaRepository
{
    Tarefas Adicionar(Tarefas novaTarefa);
    Tarefas? ObterPorId(int id);
    List<Tarefas> ObterTodos();
}
