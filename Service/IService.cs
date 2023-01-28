using Informacao.Nutricional.DTOs;

namespace Informacao.Nutricional.Service;

public interface IService
{
    IEnumerable<InfoNutri> MediaPonderada(Dictionary<int, double> formula,
                                          IEnumerable<InfoNutri> infos);

    IDictionary<string, double> SomarNutrientes(IEnumerable<InfoNutri> infos);
}
