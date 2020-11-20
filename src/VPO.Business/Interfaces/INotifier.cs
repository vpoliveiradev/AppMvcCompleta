using System.Collections.Generic;
using VPO.Business.Notifications;

namespace VPO.Business.Interfaces
{
    public interface INotifier
    {
         bool HasNotification();

         List<Notification> GetNotifications();

         void Handle(Notification notification);
    }
}