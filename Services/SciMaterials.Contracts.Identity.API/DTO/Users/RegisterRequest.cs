namespace SciMaterials.Contracts.Identity.API.DTO.Users;

public class RegisterRequest
{
    public string? NickName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}