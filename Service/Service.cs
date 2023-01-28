using Informacao.Nutricional.DataAccess;
using Informacao.Nutricional.DTOs;

namespace Informacao.Nutricional.Service;

public class Service: IService
{
    private readonly ISqlDataAccess _sqlDataAccess;

    public Service(ISqlDataAccess sqlDataAccess)
    {
        _sqlDataAccess = sqlDataAccess;
    }

    public IEnumerable<InfoNutri> MediaPonderada(Dictionary<int, double> formula,
                                                 IEnumerable<InfoNutri> infos)
    {
        foreach(var info in infos)
        {
            info.Gramas *= (formula[info.IngredienteId] / 100.00);
        }

        return infos;
    }

}
