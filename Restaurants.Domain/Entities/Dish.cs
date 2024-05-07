namespace Restaurants.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }             //Id is provided, since we might want to modify a dishes price
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        
    }
}
