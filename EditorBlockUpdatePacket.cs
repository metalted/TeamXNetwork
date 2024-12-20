using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent to the server to notify about a block update, or sent from the server to the client to notify about another players block update.
    /// </summary>
    public struct EditorBlockUpdatePacket : IPacket
    {
        /// <summary>
        /// The SteamID of the client requesting the block update.
        /// </summary>
        public ulong SteamID;

        /// <summary>
        /// The serialized string representation of the updated block data.
        /// </summary>
        public string BlockString;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            BlockString = im.ReadString();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(BlockString);
        }
    }
}
