using System.Threading;
using System.Threading.Tasks;

namespace Colosoft.Notifications
{
    public static class Notification
    {
        public static INotificationDispatcher Dispatcher { get; set; }

        public static Task<MessageResult> Dispatch(
            this INotificationDispatcher dispatcher,
            IMessageFormattable message,
            CancellationToken cancellationToken = default) =>
            dispatcher?.Dispatch(new NotificationInfo(message), cancellationToken);

        public static Task<MessageResult> Dispatch(
            this INotificationDispatcher dispatcher,
            IMessageFormattable message,
            NotificationType type,
            CancellationToken cancellationToken = default) =>
            dispatcher?.Dispatch(new NotificationInfo(message, type: type), cancellationToken);

        public static Task<MessageResult> Dispatch(
            this INotificationDispatcher dispatcher,
            IMessageFormattable message,
            IMessageFormattable caption,
            CancellationToken cancellationToken = default) =>
            dispatcher?.Dispatch(new NotificationInfo(message, caption), cancellationToken);

        public static Task<MessageResult> Dispatch(
            this INotificationDispatcher dispatcher,
            IMessageFormattable message,
            IMessageFormattable caption,
            MessageResultOption resultOption,
            CancellationToken cancellationToken) =>
            dispatcher?.Dispatch(new NotificationInfo(message, caption, resultOption), cancellationToken);

        public static Task<MessageResult> Dispatch(
            this INotificationDispatcher dispatcher,
            IMessageFormattable message,
            IMessageFormattable caption,
            MessageResultOption resultOption,
            NotificationType type,
            MessageResult dafaultMessageResult,
            CancellationToken cancellationToken = default) =>
            dispatcher?.Dispatch(new NotificationInfo(message, caption, resultOption, dafaultMessageResult, type), cancellationToken);
    }
}
