using MediatR;
using Microsoft.Extensions.Logging;
using Restaurants.Domain.Constants;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Exceptions;
using Restaurants.Domain.Interfaces;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Dishes.Commands.DeleteDish;

public class DeleteDishCommandHandler(ILogger<DeleteDishCommand> logger, 
    IDishesRepository dishRepository, 
    IRestaurantsRepository restaurantsRepository, 
    IRestaurantAuthorizationService restaurantAuthorizationService) : IRequestHandler<DeleteDishCommand>
{
    public async Task Handle(DeleteDishCommand request, CancellationToken cancellationToken)
    {
        logger.LogWarning("Deleting all dishes from restaurant: {RestaurantId}", request.RestaurantId);

        var restaurant = await restaurantsRepository.GetByIdAsync(request.RestaurantId);

        if (restaurant == null)
        {
            throw new NotFoundException(nameof(Restaurant), request.RestaurantId.ToString());
        }

        if (!restaurantAuthorizationService.Authorize(restaurant, ResourceOperation.Update))
            throw new ForbidException();

        var dishes = restaurant.Dishes;

        if (dishes.Any())
        {
            await dishRepository.DeleteAsync(dishes);
        }
    }
}
