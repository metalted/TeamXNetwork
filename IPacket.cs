using Lidgren.Network;

namespace TeamXNetwork
{
    public interface IPacket
    {
        void Deserialize(NetIncomingMessage im);

        void Serialize(NetOutgoingMessage om);
    }
}
