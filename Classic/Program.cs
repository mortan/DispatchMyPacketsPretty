using System;

namespace Sample.Classic
{
    class Program
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

        private void OnPacketReceived(ServerPacketBase packet)
        {
            // If-else of doom
            var type = packet.GetType();
            if (type == typeof (LoginPacket))
            {
                HandlePacket((LoginPacket)packet);
            }
            else if (type == typeof (MessagePacket))
            {
                HandlePacket((MessagePacket)packet);
            }
            else
            {
                throw new ArgumentException("Unkown packet type: " + nameof(packet));
            }
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
