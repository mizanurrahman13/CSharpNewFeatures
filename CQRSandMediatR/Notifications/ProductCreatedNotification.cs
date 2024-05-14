using MediatR;

namespace CQRSandMediatR.Notifications;

public record ProductCreatedNotification(Guid Id) : INotification;
