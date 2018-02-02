using System;

namespace PS3DiscordRPCApp
{
    internal class DiscordController
    {
        public DiscordRPC.RichPresence presence;
        DiscordRPC.EventHandlers handlers;
        public string applicationId = "407260536586371098";
        public string optionalSteamId;

        /// <summary>
        ///     Initializes Discord RPC
        /// </summary>
        public void Initialize()
        {
            handlers = new DiscordRPC.EventHandlers();
            handlers.readyCallback = ReadyCallback;
            handlers.disconnectedCallback += DisconnectedCallback;
            handlers.errorCallback += ErrorCallback;
            DiscordRPC.Initialize(applicationId, ref handlers, true, optionalSteamId);
        }

        public void ReadyCallback()
        {
            Console.WriteLine("Discord RPC is ready!");
        }

        public void DisconnectedCallback(int errorCode, string message)
        {
            Console.WriteLine($"Error: {errorCode} - {message}");
        }

        public void ErrorCallback(int errorCode, string message)
        {
            Console.WriteLine($"Error: {errorCode} - {message}");
        }
    }
}
