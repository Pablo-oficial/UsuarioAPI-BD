using Microsoft.EntityFrameworkCore;
using UsuarioAPI.Models;

namespace UsuarioAPI.Models;

public class UsuarioContext : DbContext
{
    public UsuarioContext(DbContextOptions<UsuarioContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> TodoItems { get; set; } = null!;
}