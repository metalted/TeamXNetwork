using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet containing the current state of a player, including position, rotation, and mode.
    /// </summary>
    public struct PlayerStatePacket : IPacket
    {
        /// <summary>
        /// The SteamID of the player.
        /// </summary>
        public ulong SteamID;

        /// <summary>
        /// The X-coordinate of the player's position.
        /// </summary>
        public float PositionX;

        /// <summary>
        /// The Y-coordinate of the player's position.
        /// </summary>
        public float PositionY;

        /// <summary>
        /// The Z-coordinate of the player's position.
        /// </summary>
        public float PositionZ;

        /// <summary>
        /// The X-component of the player's rotation in Euler angles.
        /// </summary>
        public float EulerX;

        /// <summary>
        /// The Y-component of the player's rotation in Euler angles.
        /// </summary>
        public float EulerY;

        /// <summary>
        /// The Z-component of the player's rotation in Euler angles.
        /// </summary>
        public float EulerZ;

        /// <summary>
        /// The player's current mode (e.g., build, race, etc.).
        /// </summary>
        public byte Mode;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            PositionX = im.ReadFloat();
            PositionY = im.ReadFloat();
            PositionZ = im.ReadFloat();
            EulerX = im.ReadFloat();
            EulerY = im.ReadFloat();
            EulerZ = im.ReadFloat();
            Mode = im.ReadByte();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(PositionX);
            om.Write(PositionY);
            om.Write(PositionZ);
            om.Write(EulerX);
            om.Write(EulerY);
            om.Write(EulerZ);
            om.Write(Mode);
        }
    }
}
