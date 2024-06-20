using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Restaurants.Application.Restaurants.Commands.CreateRestaurant;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Exceptions;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants.Commands.DeleteRestaurant;

public class DeleteRestaurantCommandHandler(ILogger<CreateRestaurantCommand> logger, IRestaurantsRepository repository) : IRequestHandler<DeleteRestaurantCommand>
{
    public async Task Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Deleting restaurant with id {RestaurantId}", request.Id);

        var restaurant = await repository.GetByIdAsync(request.Id);
        
        if (restaurant == null)
        {
            throw new NotFoundException(nameof(Restaurant), request.Id.ToString());
        }

        await repository.DeleteAsync(restaurant);
       
    }
}
