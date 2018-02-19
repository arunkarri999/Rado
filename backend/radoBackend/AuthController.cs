using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using radoBackend.models;

[Route("api/auth")]
public class AuthController : Controller
{

    [HttpPost("/SignUp")]
    public SignUp createUser([FromBody] SignUp signUpBody)
    {
        // TODO: DeSerialize 
        

       // TODO: Store Credentials
       
        return new SignUp();
    }

}