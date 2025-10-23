using System;

namespace GerenciadorTarefasApi.Entities;

public class Usuarios
{
    public int Id { get; set; }
    public string NomeUsuario { get; set; } = string.Empty;
    public string EmailUsuario { get; set; } = string.Empty;
    public ICollection<Tarefas> Tarefas { get; set; } = new List<Tarefas>();
}
