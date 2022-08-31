// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_offline.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class COffline_GetOfflineLogonTicket_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint priority
        {
            get => __pbn__priority.GetValueOrDefault();
            set => __pbn__priority = value;
        }
        public bool ShouldSerializepriority() => __pbn__priority != null;
        public void Resetpriority() => __pbn__priority = null;
        private uint? __pbn__priority;

        [global::ProtoBuf.ProtoMember(2)]
        public bool perform_encryption
        {
            get => __pbn__perform_encryption.GetValueOrDefault();
            set => __pbn__perform_encryption = value;
        }
        public bool ShouldSerializeperform_encryption() => __pbn__perform_encryption != null;
        public void Resetperform_encryption() => __pbn__perform_encryption = null;
        private bool? __pbn__perform_encryption;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class COffline_GetOfflineLogonTicket_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public byte[] serialized_ticket
        {
            get => __pbn__serialized_ticket;
            set => __pbn__serialized_ticket = value;
        }
        public bool ShouldSerializeserialized_ticket() => __pbn__serialized_ticket != null;
        public void Resetserialized_ticket() => __pbn__serialized_ticket = null;
        private byte[] __pbn__serialized_ticket;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] signature
        {
            get => __pbn__signature;
            set => __pbn__signature = value;
        }
        public bool ShouldSerializesignature() => __pbn__signature != null;
        public void Resetsignature() => __pbn__signature = null;
        private byte[] __pbn__signature;

        [global::ProtoBuf.ProtoMember(3)]
        public Offline_Ticket encrypted_ticket { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class COffline_GetUnsignedOfflineLogonTicket_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class COffline_OfflineLogonTicket : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint accountid
        {
            get => __pbn__accountid.GetValueOrDefault();
            set => __pbn__accountid = value;
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint rtime32_creation_time
        {
            get => __pbn__rtime32_creation_time.GetValueOrDefault();
            set => __pbn__rtime32_creation_time = value;
        }
        public bool ShouldSerializertime32_creation_time() => __pbn__rtime32_creation_time != null;
        public void Resetrtime32_creation_time() => __pbn__rtime32_creation_time = null;
        private uint? __pbn__rtime32_creation_time;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class COffline_GetUnsignedOfflineLogonTicket_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public COffline_OfflineLogonTicket ticket { get; set; }

    }

    public interface IOffline
    {
        COffline_GetOfflineLogonTicket_Response GetOfflineLogonTicket(COffline_GetOfflineLogonTicket_Request request);
        COffline_GetUnsignedOfflineLogonTicket_Response GetUnsignedOfflineLogonTicket(COffline_GetUnsignedOfflineLogonTicket_Request request);
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
