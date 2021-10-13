using NextGen.Domain.Common;
using System.Threading.Tasks;

namespace NextGen.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
