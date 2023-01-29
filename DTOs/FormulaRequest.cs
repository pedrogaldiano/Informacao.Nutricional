namespace Informacao.Nutricional.DTOs;

public class FormulaRequest
{
    public int GrupoId { get; set; }
    public IDictionary<int, double> FormulaDict { get; set; }
}