using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants.Commands.CreateRestaurant;

public class CreateRestaurantCommandHandler (ILogger<CreateRestaurantCommand> logger, IMapper mapper, IRestaurantsRepository repository) : IRequestHandler<CreateRestaurantCommand, int>

{    
    public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Creating a new restaurant");

        var restaurant = mapper.Map<Restaurant>(request);

        int id = await repository.CreateAsync(restaurant);
        return id;
    }
}
