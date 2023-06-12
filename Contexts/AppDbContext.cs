
using Microsoft.EntityFrameworkCore;
using WebAppnbloom.Models; // inserir não esquercer 

namespace WebAppnbloom.Contexts;
//DbContext --> Como se fosse o Banco
//DbSet --> Tabela

//Banco ":" herança

public class AppDbContext:DbContext{
//tabela

    public DbSet<Competencia> Competencias=> Set<Competencia>();

    //override sobre escrita =polimorfismo
    //mesmo metodo sobre escrito
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAB-F08-18;Database=WebAppBloom;User Id=SA;Password=senai@123;TrustServerCertificate=True;");
    }


}