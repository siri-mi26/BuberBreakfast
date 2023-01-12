namespace BuberBreakfast.Contracts.Breakfast;

public record BreakfastRequestResponse (
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
);