using CQRSandMediatR.Features.Products.DTOs;
using MediatR;

namespace CQRSandMediatR.Features.Products.Queries.Get;

public record GetProductQuery(Guid Id) : IRequest<ProductDto>;
