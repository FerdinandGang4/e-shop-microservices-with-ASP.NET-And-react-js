using MediatR;

namespace CatalogApi.Product.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Descrption, string Image, Decimal price):IRequest<CreateProductResult>;// input
    public record CreateProductResult(Guid Id);// result
    internal class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {

        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

