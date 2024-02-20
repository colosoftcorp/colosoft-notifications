using System;
using System.Threading;
using System.Threading.Tasks;

namespace Colosoft.Notifications
{
    public interface INotificationService
    {
        Task Notify(NotificationMessage message, CancellationToken cancellationToken);

        Task NotifyError(string message, CancellationToken cancellationToken);

        Task NotifyError(Exception exception, string message, CancellationToken cancellationToken);

        Task NotifyError(string message, string details, CancellationToken cancellationToken);

        Task NotifyInformation(string message, CancellationToken cancellationToken);

        Task NotifyWarning(string message, CancellationToken cancellationToken);

        Task NotifySuccess(string message, CancellationToken cancellationToken);
    }
}
