namespace Sample.Visitor
{
    public class LoginPacket : IServerPacket
    {
        public void ExecuteHandler(IPacketHandler handler)
        {
            handler.HandlePacket(this);
        }
    }
}