using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using P1_AP1_WilliamRodriguez.DAL;
using P1_AP1_WilliamRodriguez.Models;



namespace P1_AP1_WilliamRodriguez.Services;

public class RegistroServices (IDbContextFactory<Contexto> dbContextFactory)
{
    public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
    {
        using var ctx = await dbContextFactory.CreateDbContextAsync();
        return await ctx.Registro
                        .Where(criterio)
                        .AsNoTracking()
                        .ToListAsync();
    }

}