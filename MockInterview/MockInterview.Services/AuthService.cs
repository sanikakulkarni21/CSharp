using MockInterview.Data;
using MockInterview.Models;

namespace MockInterview.Services;

public class AuthService
{
    private readonly IUserRepository _userRepo;
    private readonly ITokenGenerator _tokenGenerator;

    public AuthService(IUserRepository userRepo, ITokenGenerator tokenGenerator)
    {
        _userRepo = userRepo;
        _tokenGenerator = tokenGenerator;
    }

    public async Task<(bool Success, string? Error, User? User, string? Token)> RegisterAsync(string name, string email, string password)
    {
        var existing = await _userRepo.GetByEmailAsync(email);
        if (existing != null)
            return (false, "Email already registered", null, null);

        var hash = BCrypt.Net.BCrypt.HashPassword(password);
        var user = new User { Name = name, Email = email, PasswordHash = hash };
        var id = await _userRepo.CreateAsync(user);
        user.Id = id;

        var token = _tokenGenerator.GenerateToken(user);
        return (true, null, user, token);
    }

    public async Task<(bool Success, string? Error, User? User, string? Token)> LoginAsync(string email, string password)
    {
        var user = await _userRepo.GetByEmailAsync(email);
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            return (false, "Invalid email or password", null, null);

        var token = _tokenGenerator.GenerateToken(user);
        return (true, null, user, token);
    }
}