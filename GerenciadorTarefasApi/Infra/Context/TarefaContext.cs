using System;
using GerenciadorTarefasApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefasApi.Infra.Context;

public class TarefaContext : DbContext
{
    public TarefaContext(DbContextOptions<TarefaContext> options) : base(options) { }

    public DbSet<Tarefas> Tarefas { get; set; }
    public DbSet<Usuarios> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefas>(entity =>
        {
            entity.ToTable("TB_TAREFAS");
            entity.HasKey(t => t.Id);
            entity.Property(t => t.Id).HasColumnName("id_tarefa");
            entity.Property(t => t.TituloTarefa).HasColumnName("titulo_tarefa");
            entity.Property(t => t.DescricaoTarefa).HasColumnName("descricao_tarefa");
            entity.Property(t => t.DataCriacao).HasColumnName("data_criacao");
            entity.Property(t => t.DataConclusao).HasColumnName("data_conclusao");
            entity.Property(t => t.Concluida).HasColumnName("concluida");
            entity.Property(t => t.UsuarioId).HasColumnName("id_usuario");
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.ToTable("TB_USUARIOS");
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Id).HasColumnName("id_usuario");
            entity.Property(u => u.NomeUsuario).HasColumnName("nome_usuario");
            entity.Property(u => u.EmailUsuario).HasColumnName("email_usuario");
        });

        modelBuilder.Entity<Tarefas>()
        .HasOne(t => t.Usuarios)
        .WithMany(u => u.Tarefas)
        .HasForeignKey(t => t.UsuarioId);
    }
}
