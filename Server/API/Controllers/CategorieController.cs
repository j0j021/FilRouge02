using BLL.Interfaces;
using Domain.DTO.Request;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Authorize(Roles = "Admin,Utilisateur")]
[Route("api/categorie")]

public class CategorieController : APIBaseController
{
    private readonly ICategorieService _categorieService;

    public CategorieController(ICategorieService categorieService)
    {
        _categorieService = categorieService;
    }

    [HttpGet]

    [Route("categorie")]
    public async Task<IActionResult> GetCategorieAsync()
    {
        return Ok(await _categorieService.GetCategoriesAsync());


    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetMaterielByCategorie(int id)
    {
        var res = await _categorieService.GetMaterielByIdCat(id);

        return Ok(res);
    }
    [HttpPost("add")]
    [Authorize(Roles = "Admin")]
    public async Task<int> CreateCategorieAsync([FromBody] CreateCategorieRequest request)
    {
        Categorie cat = new Categorie(request.Label);
        var res = _categorieService.AddCategorieAsync(cat);
        return await res;

    }
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteCategorieAsync([FromRoute] int id)
    {
        if (id == 0) return BadRequest();
        else
        {
            var res = await _categorieService.DeleteCategorieAsync(id);
            if (res == 0) return NotFound();
            else return Ok(res);

        }
    }
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> ModifyCategoriAsync(int id, [FromBody] ModifyCategorieDTORequest categorie)
    {
        Categorie cat = new Categorie(categorie.Label);

        var res = await _categorieService.UpdateCategorieAsync(id, cat);
        return Ok(res);
    }
    [HttpGet("materiel {id}")]
    public async Task<IActionResult> GetCategorieMaterielAsync(int id)
    {
        var res = await _categorieService.GetCategorieMaterielAsync(id);
        return Ok(res);
    }

}

