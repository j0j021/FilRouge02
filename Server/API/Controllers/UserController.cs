using BLL.Interfaces;
using Domain.DTO.Request;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/user")]
public class UserController : APIBaseController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet]
    [Route("user")]
    public async Task<IActionResult> GetUsersAsync()
    {

        return Ok(await _userService.GetUsersAsync());
    }
    [HttpPost("assign")]
    public async Task<IActionResult> AssignerMaterielAsync([FromBody] AssignerMaterielDTORequest lien)
    {
        return Ok(await _userService.AssignerMaterielAsync(lien));
    }
}




