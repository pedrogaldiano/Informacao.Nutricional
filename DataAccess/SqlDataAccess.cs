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
        
        var query = "SELECT id, ingrediente FROM [nutricaodb].[dbo].[informacao_nutricional]";
               
        return await connection.QueryAsync<IngredienteModel>(query);
    }

    public async Task<IEnumerable<NutrientesModel>> ListarPorIDs(int[] listaIDs)
    {
        using IDbConnection connection =
            new SqlConnection(_config.GetConnectionString("SqlConnection"));

        var listaString = String.Join(",", listaIDs);

        // Sim, eu sei que usar params seria mais seguro, mas eu to garantindo na controller
        // que eu recebo um array de int e na ListaPorIDs, então não tem como vir outra coisa.
        var query = $"SELECT * FROM [nutricaodb].[dbo].[informacao_nutricional] WHERE id IN ({ listaString })";

        return await connection.QueryAsync<NutrientesModel>(query);
    }
}