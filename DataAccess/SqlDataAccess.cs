namespace Informacao.Nutricional.DataAccess;

using System.Data;
using Dapper;
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

    public async Task<IEnumerable<NutrientesModel>> ListarPorIDs(int[] listaIDs)
    {
        using IDbConnection connection =
            new SqlConnection(_config.GetConnectionString("SqlConnection"));

        var listaString = String.Join(",", listaIDs);

        var query = $"SELECT * FROM [nutricaodb].[dbo].[informacao_nutricional] WHERE id IN ({ listaString })";

        return await connection.QueryAsync<NutrientesModel>(query);
    }

    public async Task<IEnumerable<VdModel>> ListarPorID(int id)
    {
        using IDbConnection connection = 
            new SqlConnection(_config.GetConnectionString("SqlConnection"));

        var query = $"SELECT * FROM [nutricaodb].[dbo].[valores_referencia] WHERE id = @ID";

        return await connection.QueryAsync<VdModel>(query, new { ID = id });
    }
}