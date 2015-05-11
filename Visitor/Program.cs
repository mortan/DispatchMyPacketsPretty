using System;

namespace Sample.Visitor
{
    class Program : IPacketHandler
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        private void Run()
        {
            OnPacketReceived(new LoginPacket());
            OnPacketReceived(new MessagePacket());
        }

        private void OnPacketReceived(IServerPacket packet)
        {
            packet.ExecuteHandler(this);
        }

        public void HandlePacket(LoginPacket packet)
        {
            Console.WriteLine("HandlePacket(LoginPacket packet): " + packet.GetType());
        }

        public void HandlePacket(MessagePacket packet)
        {
            Console.WriteLine("HandlePacket(MessagePacket packet): " + packet.GetType());
        }
    }
}
