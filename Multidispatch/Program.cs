using System;

namespace Sample.Multidispatch
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

            // -> Runtime Exception
            //OnPacketReceived(new MessagePacket());
        }

        private void OnPacketReceived(ServerPacketBase packet)
        {
            HandlePacket((dynamic)packet);
        }

        public void HandlePacket(LoginPacket packet)
        {
            Console.WriteLine("HandlePacket(LoginPacket packet): " + packet.GetType());
        }

        /*
        public void HandlePacket(MessagePacket packet)
        {
            Console.WriteLine("HandlePacket(MessagePacket packet): " + packet.GetType());
        }*/
    }
}
