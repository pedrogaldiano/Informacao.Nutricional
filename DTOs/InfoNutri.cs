namespace Informacao.Nutricional.DTOs;

public class InfoNutri
{
    public int IngredienteId { get; set; }
    public string Ingrediente { get; set; }
    public int NutrienteId { get; set; }
    public string Nutriente { get; set; }
    public double Gramas { get; set; }
}

public static class InfoNutriExtensions
{
    public static IEnumerable<InfoNutri> MediaPonderada(
        this IEnumerable<InfoNutri> infos,
        IDictionary<int, double> formula)
    {
        foreach (var info in infos)
        {
            info.Gramas *= (formula[info.IngredienteId] / 100.00);
        }
        return infos;
    }

    public static IDictionary<int, double> SomarNutrientes(
        this IEnumerable<InfoNutri> infos)
    {
        var result = new Dictionary<int, double>();
        foreach (var info in infos)
        {
            if (!result.TryAdd(info.NutrienteId, info.Gramas))
            {
                result[info.NutrienteId] += info.Gramas;
            }
        }
        return result;
    }
}