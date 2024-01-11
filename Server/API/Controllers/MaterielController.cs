using BLL.Interfaces;
using Domain.DTO.Request;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Authorize(Roles = "Admin,Utilisateur")]
[Route("api/materiel")]
public class MaterielController : APIBaseController
{
    private readonly IMaterielService _materielService;
    public MaterielController(IMaterielService materielService)
    {
        _materielService = materielService;
    }
    [HttpGet]
    [Route("materiel")]
    public async Task<IActionResult> GetMaterielAsync()
    {
        return Ok(await _materielService.GetMaterielAsync());

    }
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteMaterielAsync([FromRoute] int id)
    {
        if (id != 0)
        {
            var res = await _materielService.DeleteMaterielAsync(id);
            if (res == 0)
                return BadRequest();
            else return Ok(res);
            return Ok();
        }
        else return NotFound();
    }
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateMaterielAsync(int id, [FromBody] ModifyMaterielDTORequest materiel)

    {
        Materiel mat = new Materiel(id, materiel.Name, null, DateTime.Now, DateTime.Now);
        var res = await _materielService.UpdateMaterielAsync(mat);
        return Ok(res);
    }
    [HttpPost()]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddMaterielCategorieAsync([FromBody] AddMaterielDTORequest materiel)
    {
        var res = await _materielService.AddMaterielCategorieAsync(materiel);
        return Ok(res);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetMaterielByCategorie([FromRoute] int id)
    {
        var res = await _materielService.GetMaterielByCategorieAsync(id);
        return Ok(res);

    }
}
