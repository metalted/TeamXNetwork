using Lidgren.Network;

namespace TeamXNetwork
{
    /// <summary>
    /// A general purpose custom message.
    /// </summary>
    public struct CustomMessagePacket : IPacket
    {
        /// <summary>The player's SteamID.</summary>
        public ulong SteamID;

        /// <summary>The payload of the message</summary>
        public string Payload;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            Payload = im.ReadString();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(Payload);
        }
    }
}
