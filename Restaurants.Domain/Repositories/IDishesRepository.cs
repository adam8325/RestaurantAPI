using Restaurants.Domain.Entities;

namespace Restaurants.Domain.Repositories;

public interface IDishesRepository
{
    Task<int> Create(Dish entity);
    public Task DeleteAsync(IEnumerable<Dish> dishes);
}
