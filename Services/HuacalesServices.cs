using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using P1_AP1_WilliamRodriguez.DAL;
using P1_AP1_WilliamRodriguez.Models;

namespace P1_AP1_WilliamRodriguez.Services;

public class HuacalesServices (IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe (int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Huacales.AnyAsync(a => a.EntradaId == id);
    }

    public async Task<bool> Insertar(EntradasHuacales huacales)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Add(huacales);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(EntradasHuacales huacales)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Update(huacales);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Eliminar(int EntradaId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var Entidad = await contexto.Huacales.FindAsync(EntradaId);
        if (Entidad == null) return false;
        contexto.Remove(EntradaId);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<EntradasHuacales> Buscar(int aportesId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Huacales.FindAsync(aportesId);
    }
    public async Task<bool> Guardar(EntradasHuacales huacales)
    {
        if (!await Existe(huacales.EntradaId))
        {
            return await Insertar(huacales);
        }
        else
        {
            return await Modificar(huacales);
        }
    }

    public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
    {
        using var ctx = await DbFactory.CreateDbContextAsync();
        return await ctx.Huacales
                        .Where(criterio)
                        .AsNoTracking()
                        .ToListAsync();
    }

}