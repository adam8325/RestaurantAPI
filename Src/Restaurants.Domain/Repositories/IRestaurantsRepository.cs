﻿using Restaurants.Domain.Constants;
using Restaurants.Domain.Entities;
using System.Threading.Tasks;

namespace Restaurants.Domain.Repositories;

public interface IRestaurantsRepository
{
    public Task<IEnumerable<Restaurant>> GetAllAsync();
    public Task<Restaurant?> GetByIdAsync(int id);
    public Task<int> CreateAsync(Restaurant restaurant);
    public Task DeleteAsync(Restaurant restaurant);
    Task SaveChanges();
    Task<(IEnumerable<Restaurant>, int)> GetAllMatchingAsync(string? searchPhrase, int pageSize, int pageNumber, string? sortBy, SortDirection sortDirection);
}
