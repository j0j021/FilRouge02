using BLL.Interfaces;
using DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BLL.Implementations;
internal class SecurityService : ISecurityService
{
    public IConfiguration _configuration { get; }

    private readonly IUOW _dbContext;
    public SecurityService(IConfiguration configuration, IUOW db_context)
    {
        _configuration = configuration;
        _dbContext = db_context;
    }

    public async Task<string> SignIn(string username, string password)
    {
        var role = await _dbContext.User.GetRoleAsync(username, password);
        if (role is not null)
        {

            if (role.Role == "Admin" || role.Role == "Utilisateur")
            {
                return await Task.FromResult(GenerateJwtToken(username, new List<string>() { role.Role }));
            }
        }
        else return null;
        return null;
    }

    private string GenerateJwtToken(string username, List<string> roles)
    {
        //Add User Infos
        var claims = new List<Claim>(){
               new Claim(JwtRegisteredClaimNames.Sub, username), //ID User (Subject)
               new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), //ID Token
               new Claim(ClaimTypes.NameIdentifier, username) //ID User (NameIdentifier)  == (Subject)
           };

        //Add Roles
        roles.ForEach(role =>
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        });

        //Signing Key
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //Expiration time
        var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

        //Create JWT Token Object
        var token = new JwtSecurityToken(
            _configuration["JwtIssuer"],//Issuer
            _configuration["JwtIssuer"],//Audience
            claims,//Charge utile (Payload)
            expires: expires, //Expiration time
            signingCredentials: creds //Signing Key
        );

        //Serializes a JwtSecurityToken into a JWT in Compact Serialization Format.
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
