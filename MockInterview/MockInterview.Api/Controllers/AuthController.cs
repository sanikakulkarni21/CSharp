using Microsoft.AspNetCore.Mvc;
using MockInterview.Api.DTOs;
using MockInterview.Services;

namespace MockInterview.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var (success, error, user, token) = await _authService.RegisterAsync(request.Name, request.Email, request.Password);
        if (!success) return BadRequest(new { message = error });
        Console.WriteLine("User registered successfully.");
        return Ok(new AuthResponse(user!.Id, user.Name, user.Email, token!));
        
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var (success, error, user, token) = await _authService.LoginAsync(request.Email, request.Password);
        if (!success) return Unauthorized(new { message = error });
        Console.WriteLine("User logged in successfully.");
        return Ok(new AuthResponse(user!.Id, user.Name, user.Email, token!));
    }
}