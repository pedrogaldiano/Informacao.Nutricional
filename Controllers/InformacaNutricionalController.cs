using Informacao.Nutricional.DataAccess;
using Informacao.Nutricional.DTOs;
using Informacao.Nutricional.Models;
using Microsoft.AspNetCore.Mvc;

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

    [HttpGet("ListarTodosIngredientes")]
    public async Task<IEnumerable<IngredienteModel>> ListarTodosIngredientes()
    {
        var result = await _sqlDataAccess.ListarTodosIngredientes();
        return result;
    }

    [HttpGet("ListarTodosNutrientes")]
    public async Task<IEnumerable<NutrienteModel>> ListarTodosNutrientes()
    {
        var result = await _sqlDataAccess.ListarTodosNutrientes();
        return result;
    }

    [HttpGet("ListarTodosGrupos")]
    public async Task<IEnumerable<GrupoModel>> ListarTodosGrupos()
    {
        var result = await _sqlDataAccess.ListarTodosGrupos();
        return result;
    }


    // TODO: Recebe uma lista de IDs e retorna os respectivos ingredientes
    [HttpPost("ListarPorIDs")]
    public async Task<ActionResult<IEnumerable<IngredienteModel>>> ListarPorIDs(int[] listaIDs)
    {
        bool anyZeroOrNegatives = listaIDs.Any(val => val < 1);
        if (anyZeroOrNegatives) return BadRequest();

        var result = await _sqlDataAccess.ListarIngredientesPorIDs(listaIDs);
        return Ok(result);
    }

    // [HttpPost("Formula")]
    // public async Task<ActionResult<NutrientesModel>> Formula(Dictionary<int, double> formula)
    // {   
    //     // As chaves são menores que 1
    //     if (formula.Keys.Any(val => val < 1)) return BadRequest();

    //     // Os valores são menores ou iguais a zero
    //     if (formula.Values.Any(val => val <= 0)) return BadRequest();

    //     // A soma dos valores é diferente de 100%
    //     if (formula.Values.Sum() != 100) return BadRequest();

    //     var nutrientes = await _sqlDataAccess.ListarPorIDs(formula.Keys.ToArray());
    //     var ingredientes = nutrientes.ToList();
    //     nutrientes = null;
        
    //     // Não encontrou algum ID
    //     if (ingredientes.Count() != formula.Keys.Count()) return BadRequest();

    //     for (int i = 0; i < ingredientes.Count(); i++)
    //     {
    //         double val = formula[ingredientes[i].id];
    //         ingredientes[i].MultiplyBy(val);
    //     }

    //     var result = new NutrientesModel();
    //     result.SumAndUnify(ingredientes);
    //     ingredientes = null;

    //     return Ok(new NutrientesResponse(result));
    // }
}
