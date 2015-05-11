namespace Sample.Visitor
{
    public interface IPacketHandler
    {
        void HandlePacket(LoginPacket packet);

        void HandlePacket(MessagePacket packet);
    }
}