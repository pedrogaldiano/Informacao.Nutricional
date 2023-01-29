namespace Informacao.Nutricional.DTOs;

public class NutrienteCompleto
{
    public string Grupo { get; set; }

    public IDictionary<string, Tuple<double, double>> InfoNutri { get; set; }

}