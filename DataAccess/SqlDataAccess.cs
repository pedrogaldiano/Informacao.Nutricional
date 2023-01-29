namespace Informacao.Nutricional.DataAccess;

using System.Data;
using Dapper;
using Informacao.Nutricional.DTOs;
using Informacao.Nutricional.Models;
using Microsoft.Data.SqlClient;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<IngredienteModel>> ListarTodosIngredientes()
    {
        using IDbConnection connection = 
            new SqlConnection(_config.GetConnectionString("SqlConnection"));
        
        var query = "SELECT id, ingrediente FROM [nutricaodb].[dbo].[ingredientes]";
               
        return await connection.QueryAsync<IngredienteModel>(query);
    }

    public async Task<IEnumerable<NutrienteModel>> ListarTodosNutrientes()
    {
        using IDbConnection connection = 
            new SqlConnection(_config.GetConnectionString("SqlConnection"));

        var query = "SELECT id, nutriente FROM [nutricaodb].[dbo].[nutrientes]";

        return await connection.QueryAsync<NutrienteModel>(query);
    }

    public async Task<IEnumerable<GrupoModel>> ListarTodosGrupos()
    {
        using IDbConnection connection =
            new SqlConnection(_config.GetConnectionString("SqlConnection"));
        
        var query = "SELECT id, grupo FROM [nutricaodb].[dbo].[grupos]";

        return await connection.QueryAsync<GrupoModel>(query);
    }

    public async Task<IEnumerable<InfoNutri>> ListarIngredientesPorIDs(int[] listaIDs)
    {
        using IDbConnection connection =
            new SqlConnection(_config.GetConnectionString("SqlConnection"));

        var query = @"SELECT *
                    FROM [nutricaodb].[dbo].[informacao_nutricional] info
                    INNER JOIN ingredientes i ON info.IngredienteId=i.Id
                    INNER JOIN nutrientes n ON info.NutrienteId=n.Id
                    WHERE IngredienteId IN @ids";

        var results = await connection
            .QueryAsync<InfoNutri>(query, new { ids = listaIDs });

        return results;
    }

    public async Task<IEnumerable<ValorRef>> ListarValorRefPorGrupoID(int id)
    {
        using IDbConnection connection =
            new SqlConnection(_config.GetConnectionString("SqlConnection"));

        var query = @"SELECT GrupoId, Grupo, NutrienteId, Nutriente, ValorDiario
                    FROM [nutricaodb].[dbo].[valor_referencia] vr
                    INNER JOIN grupos g ON vr.GrupoId=g.Id
                    INNER JOIN nutrientes n ON vr.NutrienteId=n.Id
                    WHERE grupoId = @id";

        var results = await connection
            .QueryAsync<ValorRef>(query, new { id = id });

        return results;
    }
}