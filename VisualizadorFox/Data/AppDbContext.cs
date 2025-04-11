using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VisualizadorFox.Models;

namespace VisualizadorFox.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) 
    {
    

    }

    public DbSet<Clientes> Clientes => Set<Clientes>();
    public DbSet<Estoque> Estoque => Set<Estoque>();
    public DbSet<Fornecedor> Fornecedores => Set<Fornecedor>();
    public DbSet<Produtos> Produtos => Set<Produtos>();

}