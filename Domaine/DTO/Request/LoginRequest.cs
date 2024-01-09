namespace Domain.DTO.Requests;
public class LoginRequest
{
    public LoginRequest()
    {
    }

    public LoginRequest(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    public string username { get; set; }
    public string password { get; set; }
}
