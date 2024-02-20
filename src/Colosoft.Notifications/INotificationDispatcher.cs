using System.Threading;
using System.Threading.Tasks;

namespace Colosoft.Notifications
{
    public interface INotificationDispatcher
    {
        Task<MessageResult> Dispatch(NotificationInfo notification, CancellationToken cancellationToken);
    }
}
