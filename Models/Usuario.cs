using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI.Models;

public class Usuario
{
    [Key]
    public int cpf { get; set; }
    public string? nome { get; set; }
    public DateOnly data_nascimento { get; set; }
}