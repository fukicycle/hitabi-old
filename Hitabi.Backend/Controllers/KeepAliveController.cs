﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hitabi.Backend.Controllers;

[Route("/api/v1/keep-alives")]
public sealed class KeepAliveController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public IActionResult GetKeepAlive()
    {
        return Ok();
    }

    [Authorize]
    [HttpGet]
    [Route("auth")]
    public IActionResult GetKeepAliveWithAuth()
    {
        return Ok();
    }
}
