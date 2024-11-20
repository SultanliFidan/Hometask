using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data;

public partial class Ab108todosContext : DbContext
{
    public Ab108todosContext()
    {
    }

    public Ab108todosContext(DbContextOptions<Ab108todosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=AB108Todos;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Todos__3214EC07944D6C42");

            entity.Property(e => e.DeadLine).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.IsDone).HasDefaultValue(false);
            entity.Property(e => e.Title).HasMaxLength(64);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
