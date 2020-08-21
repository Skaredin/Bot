namespace Telegram.Bot.Examples.Echo
{
    public static class Configuration
    {
        public readonly static string BotToken = "1375903827:AAHl3rc9tiZkP_F3SBN43fNzEqzz79_vV5k";

#if USE_PROXY
        public static class Proxy
        {
            public readonly static string Host = "{PROXY_ADDRESS}";
            public readonly static int Port = 8080;
        }
#endif
    }
}
