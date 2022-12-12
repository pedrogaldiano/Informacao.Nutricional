using Informacao.Nutricional.Models;

namespace Informacao.Nutricional.DataAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<NutrientesModel>> ListarTodos();
    Task<IEnumerable<NutrientesModel>> ListarPorIDs(int[] ListaIDs);
}
