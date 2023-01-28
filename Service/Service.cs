using Informacao.Nutricional.DataAccess;
using Informacao.Nutricional.DTOs;
using Informacao.Nutricional.Models;

namespace Informacao.Nutricional.Service;

public class Service: IService
{
    private readonly ISqlDataAccess _sqlDataAccess;

    public Service(ISqlDataAccess sqlDataAccess)
    {
        _sqlDataAccess = sqlDataAccess;
    }

    public async Task<IEnumerable<NutrienteModel>> ListarTodosNutrientes() =>
        await _sqlDataAccess.ListarTodosNutrientes();
    
    public async Task<IEnumerable<GrupoModel>> ListarTodosGrupos() =>
        await _sqlDataAccess.ListarTodosGrupos();
    
    public async Task<IEnumerable<InfoNutri>> ListarIngredientesPorIDs(int[] listaIDs) =>
        await _sqlDataAccess.ListarIngredientesPorIDs(listaIDs);
    
    public async Task<IDictionary<string, double>> GerarInfoNutricional(
        IDictionary<int, double> formula)
    {
        var infos = await _sqlDataAccess
            .ListarIngredientesPorIDs(formula.Keys.ToArray());

        var mediaPonderada = infos.MediaPonderada(formula);

        var totalNutrientes = infos.SomarNutrientes();
        return totalNutrientes;
    }
}
