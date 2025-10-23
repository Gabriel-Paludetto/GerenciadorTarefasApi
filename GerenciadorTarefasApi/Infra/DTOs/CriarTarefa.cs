using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorTarefasApi.Infra.DTOs;

public class CriarTarefa
{
    [Required]
    public string TituloTarefa { get; set; } = string.Empty;
    [Required]
    public string DescricaoTarefa { get; set; } = string.Empty;
    [Required]
    public UsuarioDto? Usuario { get; set; }
}
