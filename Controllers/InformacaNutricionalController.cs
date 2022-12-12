using Informacao.Nutricional.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Informacao.Nutricional;

[ApiController]
[Route("api/[controller]")]
public class InformacaNutricionalController : ControllerBase
{
    private readonly ISqlDataAccess _sqlDataAccess;

    public InformacaNutricionalController(ISqlDataAccess sqlDataAccess)
    {
        _sqlDataAccess = sqlDataAccess;
    }

    [HttpGet("ListarTodos")]
    public async Task<ActionResult<IEnumerable<NutrientesModel>>> ListarTodos()
    {
        var result = await _sqlDataAccess.ListarTodos();
        return Ok(result);
    }

    [HttpPost("ListarPorIDs")]
    public async Task<ActionResult<IEnumerable<NutrientesModel>>> ListarPorIDs(int[] listaIDs)
    {
        bool anyZeroOrNegatives = listaIDs.Any(val => val < 1);
        if (anyZeroOrNegatives) return BadRequest();

        var result = await _sqlDataAccess.ListarPorIDs(listaIDs);
        return Ok(result);
    }

    [HttpPost("Formula")]
    public async Task<ActionResult<IEnumerable<NutrientesModel>>> Formula(Dictionary<int, int> formula)
    {
        if (formula.Keys.Any(val => val < 1)) return BadRequest();

        if (formula.Values.Any(val => val < 1)) return BadRequest();

        if (formula.Values.Sum() > 100) return BadRequest();


        // var result = await _sqlDataAccess.ListarPorIDs(formula.Keys.ToArray());
    }

}
