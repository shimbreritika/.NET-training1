using _17_AugRest.Data;
using _17_AugRest.Repository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _17_AugRest.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext context;
        private readonly IConfiguration configuration;

        public AuthService(AppDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public string? Login(string username, string password)
        {
            //find user
            var user = context.Users12.FirstOrDefault(u => u.UserName == username && u.Password == password);

            //invalid username/password
            if (user == null)
                return null;

            //create claims - creation of jwt
            var claims = new[] {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),//adds a claim containing the unique user ID
            new Claim(ClaimTypes.Name, user.UserName), //adds a claim containing username
            new Claim(ClaimTypes.Role,user.Role) //adds a claim containing users assigned security role 
     };
            //Get JWT Key
            //retrieves a secret string from application, converts it into byte array & builds secuirty key used for signing
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));

            //credentails

            var credentails = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //create jwt
            //instantitates a new JWT configuration object 
            // Issuer : set the token user(who made token)
            //Audience : set the token audience(who the token is intended for )
            var token = new JwtSecurityToken(issuer: configuration["Jwt:Issuer"], audience: configuration["Jwt:Audience"], claims: claims,
               expires: DateTime.UtcNow.AddHours(1), signingCredentials: credentails);

            //convert token to string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
