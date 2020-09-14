using System;
using System.Threading.Tasks;


namespace Shiny.Middleware.Push
{
    public interface IPushManager
    {
        Task Send(Notification notification, string token);
        Task SendToPlatform(Notification notification, PushPlatform platform);
        Task SendToUser(Notification notification, string userIdentifer);
        Task SendToTags(Notification notification, string[] tags);
        Task<PushRegistration> Query(string? userId = null, PushPlatform? platform = null, string? tag = null);

        Task Register(PushRegistration registration);
        Task UnRegister(PushRegistration registration);

        bool IsPlatformSupported(PushPlatform platform);
    }
}
