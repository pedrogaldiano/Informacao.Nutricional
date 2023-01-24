using Informacao.Nutricional.Models;

namespace Informacao.Nutricional.DataAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<IngredienteModel>> ListarTodosIngredientes();
    Task<IEnumerable<NutrienteModel>> ListarTodosNutrientes();
    Task<IEnumerable<GrupoModel>> ListarTodosGrupos();    
    Task<IEnumerable<NutrientesModel>> ListarPorIDs(int[] ListaIDs);
}
