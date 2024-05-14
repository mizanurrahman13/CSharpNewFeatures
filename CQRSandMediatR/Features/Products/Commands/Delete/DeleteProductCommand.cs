using MediatR;

namespace CQRSandMediatR.Features.Products.Commands.Delete;

public record DeleteProductCommand(Guid Id) : IRequest;
