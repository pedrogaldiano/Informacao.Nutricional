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

    public async Task<IEnumerable<string>> ListarIngredientesPorIDs(int[] listaIDs)
    {
        using IDbConnection connection =
            new SqlConnection(_config.GetConnectionString("SqlConnection"));

        var query = @"SELECT Ingrediente, Nutriente, Gramas
                    FROM [nutricaodb].[dbo].[informacao_nutricional] 

                    INNER JOIN ingredientes ON informacao_nutricional.IngredienteId=ingredientes.Id
                    INNER JOIN nutrientes ON informacao_nutricional.NutrienteId=nutrientes.Id

                    WHERE IngredienteId IN @ids";

        // var resultq = await connection.QueryAsync<IngredienteResponse>(query, new { ids = listaIDs });
        
        var result = await connection
            .QueryAsync<IngredienteResponse, NutrientesResponse, IngredienteResponse>(
                query,
                (i, n) => {
                    i.nutrientes = n;
                    return i;
                },
                new { ids = listaIDs },

                splitOn: "Nutriente"); 

       
var sql = "select cast(1 as decimal) ProductId, 'a' ProductName, 'x' AccountOpened, cast(1 as decimal) CustomerId, 'name' CustomerName";

var item = connection.Query<IngredienteModel, Nutrientes, IngredienteModel>(sql,
    (p, c) => { p.Customer = c; return p; }, splitOn: "CustomerId").First();

// item.Customer.CustomerId.IsEqualTo(1);

//     string strSql = "SELECT DISTINCT TableID AS [Key],TableName AS [Value] FROM dbo.TS_TStuctMaster";
// Dictionary<string,string> dicts = sqlConnection.Query<KeyValuePair<string,string>>(strSql).ToDictionary(pair => pair.Key, pair => pair.Value);


        return new string[] { "result", "aa" };
    }

    // public async Task<IEnumerable<VdModel>> ListarPorID(int id)
    // {
    //     using IDbConnection connection = 
    //         new SqlConnection(_config.GetConnectionString("SqlConnection"));

    //     var query = $"SELECT * FROM [nutricaodb].[dbo].[valores_referencia] WHERE id = @ID";

    //     return await connection.QueryAsync<VdModel>(query, new { ID = id });
    // }
}