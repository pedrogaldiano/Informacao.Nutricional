using Informacao.Nutricional.DataAccess;
using Informacao.Nutricional.DTOs;
using Informacao.Nutricional.Models;
using Informacao.Nutricional.Extensions;

namespace Informacao.Nutricional.Service;

public class Service : IService
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

    public async Task<IDictionary<int, double>> GerarInfoNutricional(
        FormulaRequest formulaRequest)
    {
        var formula = formulaRequest.FormulaDict;
        var infos = await _sqlDataAccess
            .ListarIngredientesPorIDs(formula.Keys.ToArray());

        var mediaPonderada = infos.MediaPonderada(formula);

        var totalNutrientes = infos.SomarNutrientes();
        return totalNutrientes;
    }

    public async Task<NutrienteCompleto> GerarInfoNutricionalVD(
        FormulaRequest formula)
    {
        var infoNutricional = await GerarInfoNutricional(formula);
        var valoresRef = await _sqlDataAccess.ListarValorRefPorGrupoID(formula.GrupoId);

        var result = new NutrienteCompleto(valoresRef.First().Grupo);

        foreach (var valorRef in valoresRef)
        {
            var gramas = infoNutricional.GetValueOrDefault(valorRef.NutrienteId, 0);
            var valorDiario = valorRef.ValorDiario == 0 ?
                0 : gramas * 100.00 / valorRef.ValorDiario;

            var nutriente = new NutrienteGroup()
            {
                Nutriente = valorRef.Nutriente,
                Gramas = gramas,
                ValorDiario = valorDiario
            };
            result.Nutrientes.Add(nutriente);
        }
        return result;
    }
}
