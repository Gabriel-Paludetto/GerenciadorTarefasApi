using System;
using System.ComponentModel.DataAnnotations;
namespace GerenciadorTarefasApi.Infra.DTOs;

public class UsuarioDto
{
    [Required]
    public string NomeUsuario { get; set; } = string.Empty;
    [Required]
    public string EmailUsuario { get; set; } = string.Empty;
}
