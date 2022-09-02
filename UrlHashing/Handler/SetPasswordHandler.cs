using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UrlHashing.Handler
{
    public class SetPasswordHandler
    {
        public static List<string> hashedEmailList= new List<string>
        {
            "$2a$11$Tnc7TooZtyqMUnbGzyWT7.o0wGgqwH3jdPoh7XYcNHGCoXFYv7rvu","$2a$11$maF21XcKrvEVMuE0ljI7heb827KYn0PSc8ZJgZ.dqDGq/dTb1Rczm"
        };
        public static List<string> unhashedEmailList = new List<string>
        {
            "test@gmail.com","test1@gmail.com"
        };
        public RequestDelegate Handler()
        {
            return async c =>
            {
                try{
                    var requestQuery = c.Request.Query["email"].ToString();
                    foreach (var item in unhashedEmailList){
                        bool isValidEmail = BCrypt.Net.BCrypt.Verify(item, requestQuery);
                        if (isValidEmail){
                            c.Response.Redirect($"/SetPassword/{item}");
                        }
                    }
                }
                catch{
                    // If password has salt version of it , ll reveal 
                    await c.Response.WriteAsync("It's not registered email...");
                }
            };
        }
    }
}
