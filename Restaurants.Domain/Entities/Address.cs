namespace Restaurants.Domain.Entities
{
    public class Address
    {
        //Since an address only exists with a restaurant and the navigation property is added in the Restaurant class, the Id property is therefor not needed

        public string? City { get; set; }
        public string? Street { get; set; }        
        public string? PostalCode { get; set; }
        
    }
}
