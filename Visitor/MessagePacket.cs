namespace Sample.Visitor
{
    public class MessagePacket : IServerPacket
    {
        public void ExecuteHandler(IPacketHandler handler)
        {
            handler.HandlePacket(this);
        }
    }
}