using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a response from the server containing the current state of the editor,
    /// including floor, skybox, and serialized block data.
    /// </summary>
    public struct EditorStateResponsePacket : IPacket
    {
        /// <summary>
        /// The ID of the floor material.
        /// </summary>
        public int Floor;

        /// <summary>
        /// The ID of the skybox.
        /// </summary>
        public int Skybox;

        /// <summary>
        /// The number of blocks in the editor.
        /// </summary>
        public int BlockCount;

        /// <summary>
        /// A list of serialized block data strings.
        /// </summary>
        public List<string> BlockStrings;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="om">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage om)
        {
            BlockStrings = new List<string>();
            Floor = om.ReadInt32();
            Skybox = om.ReadInt32();
            BlockCount = om.ReadInt32();
            for (int i = 0; i < BlockCount; i++)
            {
                BlockStrings.Add(om.ReadString());
            }
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(Floor);
            om.Write(Skybox);
            om.Write(BlockCount);
            foreach (string s in BlockStrings)
            {
                om.Write(s);
            }
        }
    }
}
