using Informacao.Nutricional.DataAccess;
using Informacao.Nutricional.DTOs;
using Informacao.Nutricional.Models;
using Informacao.Nutricional.Service;
using Microsoft.AspNetCore.Mvc;

namespace Informacao.Nutricional;

[ApiController]
[Route("api/[controller]")]
public class InformacaNutricionalController : ControllerBase
{
    private readonly ISqlDataAccess _sqlDataAccess;
    private readonly IService _service;

    public InformacaNutricionalController(ISqlDataAccess sqlDataAccess,
                                          IService service)
    {
        _sqlDataAccess = sqlDataAccess;
        _service = service;
    }

    [HttpGet("ListarTodosIngredientes")]
    public async Task<IEnumerable<IngredienteModel>> ListarTodosIngredientes()
    {
        var result = await _sqlDataAccess.ListarTodosIngredientes();
        return result;
    }

    [HttpGet("ListarTodosNutrientes")]
    public async Task<IEnumerable<NutrienteModel>> ListarTodosNutrientes()
    {
        return await _service.ListarTodosNutrientes();
    }

    [HttpGet("ListarTodosGrupos")]
    public async Task<IEnumerable<GrupoModel>> ListarTodosGrupos()
    {
        return await _service.ListarTodosGrupos();
    }


    //TODO: Descomentar
    [HttpPost("ListarIngredientesPorIDs")]
    public async Task<ActionResult<IEnumerable<InfoNutri>>> ListarIngredientesPorIDs(int[] listaIDs)
    {
        bool anyZeroOrNegatives = listaIDs.Any(val => val < 1);
        if (anyZeroOrNegatives) return BadRequest();

        return Ok(await _service.ListarIngredientesPorIDs(listaIDs));
    }

    [HttpPost("Formula")]
    public async Task<ActionResult<IDictionary<string, double>>> Formula(
        IDictionary<int, double> formula)
    {
        if (formula.Count() == 0) return BadRequest();

        if (formula.Keys.Any(x => x <= 0)) return BadRequest();

        if (formula.Values.Any(x => x <= 0)) return BadRequest();

        if (formula.Values.Sum() != 100) return BadRequest();

        return Ok(await _service.GerarInfoNutricional(formula));
    }

    [HttpPost("ValorDiario")]
    public async Task<ActionResult<IEnumerable<NutrienteCompleto>>> ValorDiario(
        FormulaRequest formula)
    {
        // if (formula.Count() == 0) return BadRequest();

        // if (formula.Keys.Any(x => x <= 0)) return BadRequest();

        // if (formula.Values.Any(x => x <= 0)) return BadRequest();

        // if (formula.Values.Sum() != 100) return BadRequest();

        return Ok(await _service.GerarInfoNutricionalVD(formula));
    }
}
