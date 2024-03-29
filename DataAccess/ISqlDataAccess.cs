using Informacao.Nutricional.DTOs;
using Informacao.Nutricional.Models;

namespace Informacao.Nutricional.DataAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<IngredienteModel>> ListarTodosIngredientes();
    Task<IEnumerable<NutrienteModel>> ListarTodosNutrientes();
    Task<IEnumerable<GrupoModel>> ListarTodosGrupos();    
    Task<IEnumerable<InfoNutri>> ListarIngredientesPorIDs(int[] listaIDs);
    Task<IEnumerable<ValorRef>> ListarValorRefPorGrupoID(int id);
}
