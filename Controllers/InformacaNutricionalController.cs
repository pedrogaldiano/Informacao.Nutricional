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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<NutrientesModel>>> ListarTodos()
    {
        var result = await _sqlDataAccess.ListarTodos();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<NutrientesModel>>> ListarPorIDs(int[] listaIDs)
    {
        bool anyZeroOrNegatives = listaIDs.Any(val => val < 1);
        if (!anyZeroOrNegatives) return BadRequest();

        var result = await _sqlDataAccess.ListarPorIDs(listaIDs);
        return Ok(result);
    }
}
