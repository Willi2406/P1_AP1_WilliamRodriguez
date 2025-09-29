using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using P1_AP1_WilliamRodriguez.DAL;
using P1_AP1_WilliamRodriguez.Models;



namespace P1_AP1_WilliamRodriguez.Services;

public class HuacalesServices (IDbContextFactory<Contexto> dbContextFactory)
{
    public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
    {
        using var ctx = await dbContextFactory.CreateDbContextAsync();
        return await ctx.Huacales
                        .Where(criterio)
                        .AsNoTracking()
                        .ToListAsync();
    }

}