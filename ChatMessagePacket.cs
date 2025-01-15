using Lidgren.Network;

namespace TeamXNetwork
{
    /// <summary>
    /// A chat message.
    /// </summary>
    public struct ChatMessagePacket : IPacket
    {
        /// <summary>The player's SteamID.</summary>
        public ulong SteamID;

        /// <summary>The player's username.</summary>
        public string Username;

        /// <summary>The chat message</summary>
        public string Message;

        /// <summary>The players chat color</summary>
        public string Color;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            Username = im.ReadString();
            Message = im.ReadString();
            Color = im.ReadString();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(Username);
            om.Write(Message);
            om.Write(Color);
        }
    }
}
