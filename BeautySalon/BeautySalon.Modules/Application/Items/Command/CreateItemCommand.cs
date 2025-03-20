using BeautySalon.Modules.Domain.Entities;
using MediatR;

namespace BeautySalon.Modules.Application.Items.Command
{
    public record CreateItemCommand(string ItemCode, string ItemName, int SellPrice, bool? IsInventory, short? ShopId) : IRequest<int>;

    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
    {
        private readonly IItemRepository _repository;

        public CreateItemCommandHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var item = new Items(request.ItemCode, request.ItemName, request.SellPrice, request.IsInventory, request.ShopId);
            await _repository.AddAsync(item);
            return item.ItemId;
        }
    }

}
