using System;

namespace Colosoft.Notifications
{
    public class NotificationInfo
    {
        public IMessageFormattable Message { get; set; }

        public IMessageFormattable Caption { get; set; }

        public MessageResult DefaultMessageResult { get; set; }

        public NotificationType Type { get; set; }

        public MessageResultOption Option { get; set; }

        public NotificationInfo(
            IMessageFormattable message,
            IMessageFormattable caption = null,
            MessageResultOption option = MessageResultOption.OK,
            MessageResult defaultMessageResult = MessageResult.None,
            NotificationType type = NotificationType.None)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            this.Message = message;
            this.Caption = caption;
            this.Option = option;
            this.DefaultMessageResult = defaultMessageResult;
            this.Type = type;
        }
    }
}
