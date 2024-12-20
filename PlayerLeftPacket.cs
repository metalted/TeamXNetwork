using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent from the server to notify that a player has left the session.
    /// </summary>
    public struct PlayerLeftPacket : IPacket
    {
        /// <summary>
        /// The SteamID of the player who left the session.
        /// </summary>
        public ulong SteamID;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
        }
    }
}
