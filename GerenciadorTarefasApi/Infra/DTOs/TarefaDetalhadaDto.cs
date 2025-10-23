using System;
using GerenciadorTarefasApi.Entities;

namespace GerenciadorTarefasApi.Infra.DTOs;

public class TarefaDetalhadaDto
{
    public int Id { get; set; }
    public string TituloTarefa { get; set; } = string.Empty;
    public string DescricaoTarefa { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; }
    public DateTime DataConclusao { get; set; }
    public bool Concluida { get; set; }
    public int UsuarioId { get; set; }
    public string NomeUsuario { get; set; } = string.Empty;
}
