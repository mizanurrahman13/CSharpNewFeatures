using CQRSandMediatR.Features.Products.DTOs;
using MediatR;

namespace CQRSandMediatR.Features.Products.Queries.List;

public record ListProductsQuery : IRequest<List<ProductDto>>;
