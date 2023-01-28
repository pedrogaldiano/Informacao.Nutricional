using Informacao.Nutricional.Models;

namespace Informacao.Nutricional.Service;

public interface IService
{
    Task<IEnumerable<NutrienteModel>> ListarTodosNutrientes();    
    Task<IEnumerable<GrupoModel>> ListarTodosGrupos();    
    Task<IEnumerable<InfoNutri>> ListarIngredientesPorIDs(int[] listaIDs);
    Task<IDictionary<string, double>> GerarInfoNutricional(
        IDictionary<int, double> formula);
}