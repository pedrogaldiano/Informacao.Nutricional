namespace Informacao.Nutricional.DTOs;

public class NutrienteCompleto
{
    public NutrienteCompleto(string grupo)
    {
        Grupo = grupo;
        Nutrientes = new List<NutrienteGroup>();
    }

    // public NutrienteCompleto(string grupo)
    // {
    //     Grupo = grupo;
    //     InfoNutri = new Dictionary<string, Tuple<double, double>>();
    // }

    // public string Grupo { get; set; }

    // public IDictionary<string, Tuple<double, double>> InfoNutri { get; set; }

    public string Grupo { get; set; }
    public IList<NutrienteGroup> Nutrientes { get; set; }
}

public class NutrienteGroup
{
    public string Nutriente { get; set; }
    public double Gramas { get; set; }
    public double ValorDiario { get; set; }
}