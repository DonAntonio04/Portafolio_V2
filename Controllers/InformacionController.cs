using System.Text.RegularExpressions;
using Informacion.Api.Models;
using Informacion.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Informacion.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InformacionController : ControllerBase
{

    private readonly ILogger<InformacionController> _logger;
    private readonly  InformacionServices _informacionServices;

    public InformacionController(ILogger<InformacionController> logger, InformacionServices informacionServices)
    {
        _logger = logger;
        _informacionServices = informacionServices;
    }

    [HttpGet]
    public async Task<IActionResult> GetDrivers()
    {
        var informacion = await   _informacionServices.GetAsync();
        return Ok(informacion);
    }
}
