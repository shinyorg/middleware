using System;


namespace Shiny.Middleware.Push
{
    public class PushRegistration
    {
        public string UserIdentifier { get; set; }
        public string Token { get; set; }
        public PushPlatform Platform { get; set; }
        public string[] Tags { get; set; }
    }
}
