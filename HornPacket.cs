using Lidgren.Network;

namespace TeamXNetwork
{
    /// <summary>
    /// A message for sending horns.
    /// </summary>
    public struct HornPacket : IPacket
    {
        /// <summary>The player's SteamID.</summary>
        public ulong SteamID;
        public int HornID;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            HornID = im.ReadInt32();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(HornID);
        }
    }
}
