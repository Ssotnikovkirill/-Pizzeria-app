using Microsoft.AspNetCore.Identity;

namespace PizzaDeliveryBackend.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
