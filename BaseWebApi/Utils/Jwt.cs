using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WmsApi
{
    public class JwtSetting
    {
        static JwtSetting()
        {
			Instance = new JwtSetting
			{
				Audience = GlobalBuffer.Config["JwtSetting:Audience"],
				SecurityKey = GlobalBuffer.Config["JwtSetting:SecurityKey"],
				Issuer = GlobalBuffer.Config["JwtSetting:Issuer"],
				ExpireSeconds = int.Parse(GlobalBuffer.Config["JwtSetting:ExpireSeconds"])
			};
		}

        public string SecurityKey { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public int ExpireSeconds { get; set; }

        public static JwtSetting Instance
        {
            get;
        }
    }

    public class Jwt
    {
        public static string GetToken(string userId, string userName, bool isAdmin)
        {
            //创建用户身份标识，可按需要添加更多信息
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("userid", userId, ClaimValueTypes.String), // 用户id
                new Claim("username", userName, ClaimValueTypes.String), // 用户名
                new Claim("isadmin", isAdmin.ToString() ,ClaimValueTypes.Boolean) // 是否是管理员
            };
            var key = Encoding.UTF8.GetBytes(JwtSetting.Instance.SecurityKey);
            //创建令牌
            var token = new JwtSecurityToken(
              issuer: JwtSetting.Instance.Issuer,
              audience: JwtSetting.Instance.Audience,
              signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
              claims: claims,
              notBefore: DateTime.Now,
              expires: DateTime.Now.AddSeconds(JwtSetting.Instance.ExpireSeconds)
            );

            string jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

            return jwtToken;
        }
    }
}
