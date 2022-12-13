using Informacao.Nutricional.Models;

namespace Informacao.Nutricional.DataAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<IngredienteModel>> ListarTodosIngredientes();
    Task<IEnumerable<NutrientesModel>> ListarPorIDs(int[] ListaIDs);
}
