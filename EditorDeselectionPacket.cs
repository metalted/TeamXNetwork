using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent to the server to request the deselection of a block in the editor.
    /// </summary>
    public struct EditorDeselectionPacket : IPacket
    {
        /// <summary>
        /// The SteamID of the client making the deselection request.
        /// </summary>
        public ulong SteamID;

        /// <summary>
        /// The unique identifier (UID) of the block to deselect.
        /// </summary>
        public string UID;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            UID = im.ReadString();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(UID);
        }
    }
}
