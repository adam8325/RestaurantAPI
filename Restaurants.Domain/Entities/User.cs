using Microsoft.AspNetCore.Identity;

namespace Restaurants.Domain.Entities;

public class User : IdentityUser
{
    public List<Restaurant> OwnedRestaurants { get; set; } = [];
}
