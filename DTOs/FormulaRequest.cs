namespace Informacao.Nutricional.DTOs;

public class FormulaRequest
{
    public int GrupoId { get; set; }
    public IDictionary<int, double> FormulaDict { get; set; }
}

public static class FormulaRequestExtension
{
    public  static bool isValid(this FormulaRequest formula)
    {
        if (formula == null) return false;

        if (formula.GrupoId <= 0) return false;

        if (formula.FormulaDict.Count() == 0) return false;

        if (formula.FormulaDict.Keys.Any(x => x <= 0)) return false;

        if (formula.FormulaDict.Values.Any(x => x <= 0)) return false;

        if (formula.FormulaDict.Values.Sum() != 100) return false;

        return true;
    }
}