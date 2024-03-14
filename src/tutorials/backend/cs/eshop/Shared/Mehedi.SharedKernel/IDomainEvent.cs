using MediatR;

namespace Mehedi.Core.SharedKernel
{
    /// <summary>
    /// Similar to INotification from MediatR
    /// Add this interface to get rid from another MediatR dependency to project 
    /// TODO: need to optimize later
    /// </summary>
    public interface IDomainEvent : INotification
    {
    }
}
