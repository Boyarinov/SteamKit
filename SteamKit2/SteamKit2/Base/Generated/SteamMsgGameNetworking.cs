// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_gamenetworking.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNetworking_AllocateFakeIP_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint app_id
        {
            get => __pbn__app_id.GetValueOrDefault();
            set => __pbn__app_id = value;
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint num_fake_ports
        {
            get => __pbn__num_fake_ports.GetValueOrDefault();
            set => __pbn__num_fake_ports = value;
        }
        public bool ShouldSerializenum_fake_ports() => __pbn__num_fake_ports != null;
        public void Resetnum_fake_ports() => __pbn__num_fake_ports = null;
        private uint? __pbn__num_fake_ports;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNetworking_AllocateFakeIP_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint fake_ip
        {
            get => __pbn__fake_ip.GetValueOrDefault();
            set => __pbn__fake_ip = value;
        }
        public bool ShouldSerializefake_ip() => __pbn__fake_ip != null;
        public void Resetfake_ip() => __pbn__fake_ip = null;
        private uint? __pbn__fake_ip;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<uint> fake_ports { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNetworking_ReleaseFakeIP_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint app_id
        {
            get => __pbn__app_id.GetValueOrDefault();
            set => __pbn__app_id = value;
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint fake_ip
        {
            get => __pbn__fake_ip.GetValueOrDefault();
            set => __pbn__fake_ip = value;
        }
        public bool ShouldSerializefake_ip() => __pbn__fake_ip != null;
        public void Resetfake_ip() => __pbn__fake_ip = null;
        private uint? __pbn__fake_ip;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<uint> fake_ports { get; } = new global::System.Collections.Generic.List<uint>();

    }

    public class GameNetworking : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "GameNetworking";

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CGameNetworking_AllocateFakeIP_Response>> AllocateFakeIP( CGameNetworking_AllocateFakeIP_Request request )
        {
            return UnifiedMessages.SendMessage<CGameNetworking_AllocateFakeIP_Request, CGameNetworking_AllocateFakeIP_Response>( "GameNetworking.AllocateFakeIP#1", request );
        }

        public void NotifyReleaseFakeIP(CGameNetworking_ReleaseFakeIP_Notification request )
        {
            UnifiedMessages.SendNotification<CGameNetworking_ReleaseFakeIP_Notification>( "GameNetworking.NotifyReleaseFakeIP#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "AllocateFakeIP":
                    UnifiedMessages.HandleResponseMsg<CGameNetworking_AllocateFakeIP_Response>( packetMsg );
                    break;
            }
        }

        public override void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "NotifyReleaseFakeIP":
                    UnifiedMessages.HandleNotificationMsg<CGameNetworking_ReleaseFakeIP_Notification>( packetMsg );
                    break;
            }
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
