using Microsoft.AspNetCore.Identity;

namespace ToDoList.Models
{
    public class ApplicationUser : IdentityUser
    {
        class private Login(char login)
        {
            _login=login;
        }
    }
}