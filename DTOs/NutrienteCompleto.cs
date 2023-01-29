namespace Informacao.Nutricional.DTOs;

public class NutrienteCompleto
{
    public NutrienteCompleto(string grupo)
    {
        Grupo = grupo;
        InfoNutri = new Dictionary<string, Tuple<double, double>>();
    }

    public string Grupo { get; set; }

    public IDictionary<string, Tuple<double, double>> InfoNutri { get; set; }

}