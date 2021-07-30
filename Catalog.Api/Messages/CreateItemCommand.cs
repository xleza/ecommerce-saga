using System;
using System.Threading.Tasks;
using Infrastructure;

namespace Catalog.Api.Messages
{
    public record CreateItemCommand(Guid Id, string Name, int Quantity, string Description) : ICommand<Guid>
    {
        public Task ExecuteAsync()
        {
            Validate();

            return Task.CompletedTask;
        }

        public void Validate()
        {

        }
    }
}
