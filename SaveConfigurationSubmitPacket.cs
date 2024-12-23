using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    public struct SaveConfigurationSubmitPacket : IPacket
    {
        public ulong SteamID;
        public string LevelName;
        public int AutoSaveInterval;
        public int BackupCount;
        public bool LoadBackupOnStart;
        public bool KeepBackupWithNoEditors;

        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            LevelName = im.ReadString();
            AutoSaveInterval = im.ReadInt32();
            BackupCount = im.ReadInt32();
            LoadBackupOnStart = im.ReadBoolean();
            KeepBackupWithNoEditors = im.ReadBoolean();
        }

        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(LevelName);
            om.Write(AutoSaveInterval);
            om.Write(BackupCount);
            om.Write(LoadBackupOnStart);
            om.Write(KeepBackupWithNoEditors);
        }
    }
}
