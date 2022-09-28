using Microsoft.EntityFrameworkCore;

namespace folder01.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {
        }

        public DbSet<Aluno> Alunos {get; set;}
    }
}