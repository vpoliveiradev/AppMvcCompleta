using Microsoft.AspNetCore.Mvc;
using VPO.Business.Interfaces;

namespace VPO.App.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly INotifier _notifier;

        protected BaseController(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected bool IsValid()
        {
            return !_notifier.HasNotification();
        }
    }
}