namespace Sample.Visitor
{
    public interface IServerPacket
    {
        void ExecuteHandler(IPacketHandler handler);
    }
}