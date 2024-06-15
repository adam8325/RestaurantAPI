using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Restaurants.Application.Restaurants.Commands.CreateRestaurant;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants.Commands.DeleteRestaurant;

public class DeleteRestaurantCommandHandler(ILogger<CreateRestaurantCommand> logger, IRestaurantsRepository repository) : IRequestHandler<DeleteRestaurantCommand, bool>
{
    public async Task <bool> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Deleting restaurant with id {RestaurantId}", request.Id);

        var restaurant = await repository.GetByIdAsync(request.Id);
        
        if (restaurant == null)
        {
            logger.LogWarning($"Restaurant with id {request.Id} not found");
            return false;
        }

        await repository.DeleteAsync(restaurant);

        return true;
    }
}
