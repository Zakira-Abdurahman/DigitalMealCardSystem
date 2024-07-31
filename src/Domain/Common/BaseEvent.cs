using MediatR;

namespace DigitalMealCardSystem.Domain.Common;

public abstract class BaseEvent : INotification
{
    public DateTime Timestamp { get; set; }
}
