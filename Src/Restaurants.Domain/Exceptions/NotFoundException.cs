namespace Restaurants.Domain.Exceptions;

public class NotFoundException(string ressourceType, string ressourceIdentifier) 
    : Exception($"{ressourceType} with Id: {ressourceIdentifier} doesn't exist");

    
