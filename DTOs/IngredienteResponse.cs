namespace Informacao.Nutricional.DTOs;

public class IngredienteResponse
{
    public string ingrediente { get; set; }


    public virtual ICollection<NutrientesResponse> nutrientes { get; set; }
    // public Dictionary<string, double> nutrientes  { get; set; }
}

public class NutrientesResponse
{
    public string nutriente { get; set; }
    public double gramas { get; set; }
}