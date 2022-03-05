using Ardalis.Specification;

namespace TwistedTri.ExtraLifeDashboard.SharedKernel.Interfaces
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}