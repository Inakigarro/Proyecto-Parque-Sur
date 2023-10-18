namespace Cps.Sports.Application.Domain;

/// <summary>
/// Entity that represents a sport practiced in the club.
/// </summary>
public class Sport
{
    private readonly int DisplayNameMaxLengt = 140;
    public Sport()
    {}

    public Sport(Guid correlationId)
    {
        this.CorrelationId = correlationId;
    }

    public Guid CorrelationId { get; private set; }
    public string DisplayName { get; private set; } = null!;

    public void SetDisplayName(string displayName)
    {
        if (string.IsNullOrEmpty(displayName))
        {
            throw new NullReferenceException("The provided display name is null or empty.");
        }

        if (displayName.Length > this.DisplayNameMaxLengt)
        {
            throw new InvalidOperationException($"The provided display name is longer than allowed. You entered {displayName.Length} characters, but {this.DisplayNameMaxLengt} or less is allowed.");
        }

        this.DisplayName = displayName;
    }
}
