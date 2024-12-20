using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent to the server to notify about a floor update, or sent from the server to the client to notify about another players floor update.
    /// </summary>
    public struct EditorFloorPacket : IPacket
    {
        /// <summary>
        /// The SteamID of the client making the request.
        /// </summary>
        public ulong SteamID;

        /// <summary>
        /// The ID of the floor material to apply.
        /// </summary>
        public int Floor;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            Floor = im.ReadInt32();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(Floor);
        }
    }
}
